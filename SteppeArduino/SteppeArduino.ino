bool start_send;
bool recived_data;
bool move_finished;



float incomingByte;
float data[6];
void setup() {
  // put your setup code here, to run once:
Serial.begin(115200);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available()>1)
{
  int i = 0;

  incomingByte =Serial.parseFloat(); 
  while(incomingByte !=0){
    incomingByte =Serial.parseFloat(); 
    data[i] = incomingByte;
    i++;
    if(data[3] !=0) {start_send = 1;}
   }
}
   
   if(data[0]!=0&& data[1]!=0 &&data[2]!=0 && data[3]!=0 && data[4]!=0 &&data[5]!=0 &&  start_send)  {
    Serial.println("1");
    recived_data=1;

    data[0] =0;
    data[1] =0;
    data[2] =0;
    data[3] =0;
    data[4] =0;
    data[5] =0;
    start_send = 0;
   }
   if(start_send && (data[0]==0 || data[1]==0 || data[2]==0 || data[3]==0 || data[4]==0 || data[5]==0))
   Serial.println("2");
       data[0] =0;
    data[1] =0;
    data[2] =0;
    data[3] =0;
    data[4] =0;
    data[5] =0;
   start_send = 0;
}
