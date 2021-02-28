#include <SoftwareSerial.h> 

String incomingString = ""; // for incoming serial data
int led = 13;           // the PWM pin the LED is attached to
int brightness = 0;  

void setup() {
  Serial.begin(9600); // opens serial port, sets data rate to 9600 bps
  Serial.setTimeout(30000);
  pinMode(led, OUTPUT);
}

void loop() {
  // send data only when you receive data:
  if (Serial.available() > 0) {
    // read the incoming byte:
    incomingString = Serial.readStringUntil('\n');
    Serial.println(incomingString);

    if (incomingString == "turn the light on") {
      analogWrite(led, 255);
      incomingString = "";
    }
        if (incomingString == "turn the light off") {
      analogWrite(led, 0);
      incomingString = "";
    }
  }
}