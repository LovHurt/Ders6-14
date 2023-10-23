//Value types
int number1 = 10;
long number2 = 9223152465468795467;
short number3 = -32768;
byte number4 = 255;
bool condition = false;
char character = 'A';
double number5 = 10.4;
decimal number6 = 10.4m;
string monday = "Monday";
var number7 = 10;
number7 = 'A';

enum Days
{
    Monday=10, Tuesday=20, Wednesday=30, Thursday, Friday, Saturday, Sunday
}


Console.WriteLine("Number1 is " + number1);
Console.WriteLine("Number2 is " + number2);
Console.WriteLine("Number3 is " + number3);
Console.WriteLine("Number4 is " + number4);
Console.WriteLine("Number5 is " + number5);
Console.WriteLine("Number6 is " + number6);
Console.WriteLine("Number7 is " + number7);

Console.WriteLine((int)Days.Friday);


Console.WriteLine("Character is : " + character);
Console.WriteLine("Character is : " + (int)character);


Console.ReadLine();

