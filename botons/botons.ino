int infra0 = 2;
int infra1 = 3;
int infra2 = 4;
int infra3 = 5;
int infra5 = 7;
int infra6 = 8;
int infra7 = 9;
int infra8 = 10;


void setup() {
  // put your setup code here, to run once:
  pinMode(infra0, INPUT);
  pinMode(infra1, INPUT);
  pinMode(infra2, INPUT);
  pinMode(infra3, INPUT);
  pinMode(infra5, INPUT);
  pinMode(infra6, INPUT);
  pinMode(infra7, INPUT);
  pinMode(infra8, INPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  int estat0 = digitalRead(infra0);
  int estat1 = digitalRead(infra1);
  int estat2 = digitalRead(infra2);
  int estat3 = digitalRead(infra3);
  int estat5 = digitalRead(infra5);
  int estat6 = digitalRead(infra6);
  int estat7 = digitalRead(infra7);
  int estat8 = digitalRead(infra8);
  

  if (estat0 == LOW) {
    Serial.print("0,");
  }
  if (estat1 == LOW) {
    Serial.print("1,");
  }

  if (estat2 == LOW) {
    Serial.print("2,");
  }
  
  if (estat3 == LOW) {
    Serial.print("3,");
  }
  
  if (estat5 == LOW) {
    Serial.print("5,");
  }
  
  if (estat6 == LOW) {
    Serial.print("6,");
  }
  
  if (estat7 == LOW) {
    Serial.print("7,");
  }
  
  if (estat8 == LOW) {
    Serial.print("8,");
  }

  Serial.println("");
  delay(1000);
}
