
byte number1 = 200;
// from 0 to 255
// uses 1 byte

sbyte number2 = 120;
// from -128 to 127
// uses 1 byte

short number3 = 30000;
// from -32.767 to 32.766
// uses 2 bytes

int number4 = 4000000;
// from -2.147.483.648 to 2.147.483.647
// uses 4 bytes

long number5 = 500000000000;
// from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
// uses 8 bytes


float number6 = 10.5f;
// from -3.402823e38 to 3.402823e38
// uses 4 bytes
// has 7 digits of precision

double number7 = 10.5;
// from -1.79769313486232e308 to 1.79769313486232e308
// uses 8 bytes
// has 15-16 digits of precision

decimal number8 = 10.5m;
// from -79228162514264337593543950335 to 79228162514264337593543950335
// uses 16 bytes
// has 28-29 digits of precision


char character = 'A';
// uses 2 bytes

string text = "Hello World!";
// uses 2 bytes per character

bool isTrue = true;
// uses 1 byte
