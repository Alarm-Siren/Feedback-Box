#include <Wire.h>
#include <LiquidCrystal.h>

const byte LED_ADDR = 0xA0;
const byte LED_PWM_VAL = 0xFF;
const byte LED_PWM_OFF = 0x00;

const byte LCD_RS = 5;
const byte LCD_EN = 6;
const byte LCD_D4 = 7;
const byte LCD_D5 = 8;
const byte LCD_D6 = 9;
const byte LCD_D7 = 10;

const byte BUTTON_RED = A2;
const byte BUTTON_YEL = A3;
const byte BUTTON_GRN = A1;
const byte BUTTON_BLU = A0;
const byte BUTTON_WHT = 4;
const byte PROG_EN = 2;


LiquidCrystal lcd(LCD_RS, LCD_EN, LCD_D4, LCD_D5, LCD_D6, LCD_D7);

void setup() {
  // put your setup code here, to run once:
  Wire.begin();

    Wire.beginTransmission(LED_ADDR);
    Wire.write(0x80); // Control: Auto-Increment on All Registers
    Wire.write(0x80); // 00h: MODE1
    Wire.write(0x0b); // 01h: MODE2
    Wire.write(0x00); // 02h: PWM0
    Wire.write(0x00); // 03h: PWM1
    Wire.write(0x00); // 04h: PWM2
    Wire.write(0x00); // 05h: PWM3
    Wire.write(0x00); // 06h: PWM4
    Wire.write(0x00); // 07h: PWM5
    Wire.write(0x00); // 08h: PWM6
    Wire.write(0x00); // 09h: PWM7
    Wire.write(0xFF); // 0Ah: GRPPWM
    Wire.write(0x00); // 0Bh: GRPFREQ
    Wire.write(0xAA); // 0Ch: LEDOUT0
    Wire.write(0xAA); // 0Dh: LEDOUT1
    Wire.write(0x92); // 0Eh: SUBADR1
    Wire.write(0x94); // 0Fh: SUBADR2
    Wire.write(0x98); // 10h: SUBADR3
    Wire.write(0xD0); // 11h: ALLCALLADR
    Wire.endTransmission();

  lcd.begin(16, 2);
  lcd.print("SIFBCM01-8A/0002");

  pinMode(BUTTON_RED, INPUT_PULLUP);
  pinMode(BUTTON_GRN, INPUT_PULLUP);
  pinMode(BUTTON_YEL, INPUT_PULLUP);
  pinMode(BUTTON_BLU, INPUT_PULLUP);
  pinMode(BUTTON_WHT, INPUT_PULLUP);
  pinMode(PROG_EN, INPUT_PULLUP);
  
  
}

static byte x = 255;

void loop() {
  // put your main code here, to run repeatedly:
    
    
    Wire.beginTransmission(LED_ADDR);
    Wire.write(0xA2);
    x = x - 1;
    for (int i=0; i<8; i++) {
      if (bitRead(x, i)) {
        Wire.write(LED_PWM_VAL);
      } else {
        Wire.write(LED_PWM_OFF);
      }
    }
    Wire.endTransmission();

    lcd.setCursor(0, 1);
    lcd.print("                ");
    lcd.setCursor(0, 1);
    if (!digitalRead(BUTTON_RED)) lcd.print("R");
    if (!digitalRead(BUTTON_YEL)) lcd.print("Y");
    if (!digitalRead(BUTTON_GRN)) lcd.print("G");
    if (!digitalRead(BUTTON_BLU)) lcd.print("B");
    if (!digitalRead(BUTTON_WHT)) lcd.print("W");
    if (!digitalRead(PROG_EN)) lcd.print("P");
    lcd.setCursor(8, 1);
    lcd.print(x);
    
    delay(100);
}
