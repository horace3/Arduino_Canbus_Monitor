// Arduino based Canbus monitor
//  communicates with host PC program written in C#

#include <SPI.h>
#include "mcp_can.h"

int stringSplit(char *str, const char *delim, int data[]);

// the cs pin of the version after v1.1 is default to D9
// v0.9b and v1.0 is default D10
const int SPI_CS_PIN = 10;//9;


MCP_CAN CAN(SPI_CS_PIN);                                    // Set CS pin
void setup()
{
    while(!Serial);
    delay(1000);
    Serial.begin(115200);
    delay(1000);
    CanbusStart();
}

// start canbus shield
void CanbusStart(void)
{
    Serial.println("Canbus monitor");
    while (CAN_OK != CAN.begin(CAN_250KBPS))              // init can bus : baudrate = 500k
    {
        Serial.println("CAN BUS Shield init fail");
        Serial.println(" Init CAN BUS Shield again");
        delay(100);
    }
    Serial.println("CAN BUS Shield init ok!");
}

enum CANcommand
   {CANBUSspeed=0, CANBUStransmit, Rx0mask, Rx0filter1, Rx0filter2,
             Rx1mask, Rx1filter3, Rx1filter4, Rx1filter5, Rx1filter6 };

char str[100]={0};
int strIndex=0;

void loop()
{
  // if serial data from PC process it
  if(Serial.available())
     {
      char ch=Serial.read();
      if(ch<' ')
         {               // end of line parse the text[] for ints
         char text[50]={0};
         long int result[100]={0};
         int i=stringSplit(str, " ", result);
         Serial.print(i);  Serial.print(" ints found = ");
         for(int j=0; j<i;j++)
               {/* Serial.print("result["); Serial.print(j); Serial.print("] = ");*/ Serial.print(result[j]);  Serial.print(" ");}
         Serial.println();
         strIndex=0; str[0]=0;
         if(i!=0)
         switch(result[0])     // result[0] contain the command
           {
            case CANBUSspeed: Serial.print("canbus speed "); Serial.println(result[1]);  
                if(result[1]==125) CAN.begin(CAN_125KBPS);
                if(result[1]==250) CAN.begin(CAN_250KBPS);
                if(result[1]==500) CAN.begin(CAN_500KBPS);
                 break; 
             case CANBUStransmit:     // transmit RTR or data frame
                if(result[2]) strcat(text,">Tx EXT "); else strcat(text,">Tx STD "); 
                sprintf(&text[strlen(text)],"ID %08lx ", result[1]);
                Serial.print(text);
                static unsigned char stmp[8] = {0, 0, 0, 0, 0, 0, 0, 0};
                if(result[3]) Serial.print(" RTR ");   
                else
                    {
                     Serial.print("data ");
                     for(int i = 0; i<8; i++)    // print the data
                       {
                       text[0]=0;;
                       sprintf(text,"%02X", result[4+i]);
                       Serial.print(text);
                       stmp[i]=result[4+i];
                      }
                   }
               Serial.println();
               //  byte sendMsgBuf(unsigned long id, byte ext, byte len, const byte *buf, bool wait_sent=true);               // send buf
               CAN.sendMsgBuf(result[1], result[2], result[3], 8, stmp); 
               break;
            //     byte init_Mask(byte num, byte ext, unsigned long ulData);       // init Masks
            case Rx0mask:  CAN.init_Mask(0, result[1], result[2]); break;                        // there are 2 mask in mcp2515, you need to set both of them
            case Rx1mask:  CAN.init_Mask(1, result[1], result[2]); break;                        // there are 2 mask in mcp2515, you need to set both of them
            case Rx0filter1:  CAN.init_Filt(0,result[1], result[2]); break;                            // there are 6 filter in mcp2515
            case Rx0filter2:  CAN.init_Filt(1,result[1], result[2]); break;                            // there are 6 filter in mcp2515
            case Rx1filter3:  CAN.init_Filt(2,result[1], result[2]); break;                            // there are 6 filter in mcp2515
            case Rx1filter4:  CAN.init_Filt(3,result[1], result[2]); break;                            // there are 6 filter in mcp2515
            case Rx1filter5:  CAN.init_Filt(4,result[1], result[2]); break;                            // there are 6 filter in mcp2515
            case Rx1filter6:  CAN.init_Filt(5,result[1], result[2]); break;                            // there are 6 filter in mcp2515                 
           }
         }
     else
        {  
          if(ch=='>') CanbusStart();  // if line contains > restart canbus
          else
          {                           // add character to text[]
          str[strIndex++]=ch;
          if(strIndex>99)strIndex=99;
          str[strIndex]=0;
          }
        }
     }
    // check for received message
    unsigned char len = 0;
    unsigned char buf[8]={0};
    if(CAN_MSGAVAIL == CAN.checkReceive())            // check if data coming
    {
        CAN.readMsgBuf(&len, buf);    // read data,  len: data length, buf: data buf
        unsigned long int canId = CAN.getCanId();
        char text[50]={0};
        // setup standard 11 bit or extended 29 bit frame and add ID value
        if(CAN.isExtendedFrame()) strcat(text,">Rx EXT "); else strcat(text,">Rx STD "); 
        sprintf(&text[strlen(text)],"ID %08lx ", canId);
        Serial.print(text);
        // check RTR or data frame
        if(CAN.isRemoteRequest()) Serial.print(" RTR ");   
        else
        {
           Serial.print("data ");
           for(int i = 0; i<8; i++)    // print the data
           {
            text[0]=0;;
            sprintf(text,"%02X", buf[i]);
            Serial.print(text);
            // Serial.print(buf[i], HEX);
           }
        }
        Serial.println();
    }
}

// split string str into long int values  using delimiters
// this version uses atof() and does not return tokens with value 0.0f
// return function result number of floats converted
// return converted values in data[]
int stringSplit(char *str, const char *delim, long int data[])
{
  //Serial.print("Splitting string into tokens:\n");
  //Serial.println(str);
  int i=0;
  char *pch = strtok (str,delim);       // get first token
  while (pch != NULL)
  {
    float x=999;
   //Serial.print("string found '"); Serial.print(pch);Serial.println("'");
    // check if token is a int
    if(strcmp(pch,"0") == 0)
      {data[i]=0;  /*Serial.print("int value decoded "); Serial.println(data[i]);*/ data[i++]; }
    else
      if((data[i]=atol(pch)) != 0) { /*Serial.print("int value decoded "); Serial.println(data[i]);*/ data[i++]; }
      else                             Serial.println(" not a int");
    pch = strtok (NULL, delim);   // parse next token
  }
  return i;
}



