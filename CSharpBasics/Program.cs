using CSharpBasics;

// ----- Variables and Constants -----
Console.WriteLine("-----< Variables and Constants >-----");
var numberByte = 255;
var count = 20;
var total = 26.23f;
var character = 'a';
var greeting = "Hello World";
bool isOkay = true;

const int constant = 25;
//constant = 26;

Console.WriteLine(numberByte);
Console.WriteLine(count);
Console.WriteLine(character);
Console.WriteLine(greeting);
Console.WriteLine(total);
Console.WriteLine(isOkay);

Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
Console.WriteLine();

// ----- Implicit type conversion -----
Console.WriteLine("-----< Implicit type conversion >-----");
byte b1 = 1;
int i1 = b1;
Console.WriteLine(i1);
Console.WriteLine();

// ----- Explicit type conversion -----
Console.WriteLine("-----< Explicit type conversion >-----");
int i2 = 300;
byte b2 = (byte)i2; // called as-casting
Console.WriteLine(b2);
Console.WriteLine();

// ----- Non-compatible types -----
Console.WriteLine("-----< Non-compatible types >-----");
string s = "1";
int i = Convert.ToInt32(s);
int j = int.Parse(s);
Console.WriteLine(i);
Console.WriteLine(j);
Console.WriteLine();

// ----- Classes -----
Console.WriteLine("-----< Classes >-----");
var ian = new Person();
ian.FirstName = "Ian";
ian.LastName = "Jordaan";
ian.Introduce();
Console.WriteLine();

// ----- Arrays -----
Console.WriteLine("-----< Arrays >-----");
int[] numbers = new int[5] { 1, 2, 5, 9, 3};
var values = new int[15];
values[0] = 82;
values[1] = 13;
values[2] = 22;
values[3] = 58;
values[4] = 23;
values[5] = 95;
values[6] = 451;
values[7] = 188;
values[8] = 100;
values[9] = 19;
values[10] = 21;
values[11] = 3;
values[12] = 78;
values[13] = 365;
values[14] = 45;
foreach (int number in numbers)
{
    Console.WriteLine($"Number: {number}");
}
foreach (int value in values)
{
    Console.WriteLine($"Value: {value}");
}
Console.WriteLine();

// ----- Enums -----
Console.WriteLine("-----< Enums >-----");
var method = ShippingMethod.Registered;
Console.WriteLine((int)method);
var methodId = 3;
Console.WriteLine((ShippingMethod)methodId);
Console.WriteLine();
var methodName = "Express";
var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

var t = 5;
var m = 10;

Console.WriteLine(5%10);