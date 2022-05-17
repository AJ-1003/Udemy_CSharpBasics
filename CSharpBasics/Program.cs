using CSharpBasics;
using System.Text;

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
int[] numbers = new int[5] { 1, 2, 5, 9, 3 };
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
var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
Console.WriteLine();

// ----- DateTime -----
Console.WriteLine("-----< DateTime >-----");
var dateTime = new DateTime(2022, 5, 16);
Console.WriteLine($"Display 16 May 2022: {dateTime}");

var now = DateTime.Now;
var today = DateTime.Today;

var day = now.Day;
var month = now.Month;
var year = now.Year;
var hour = now.Hour;
var minute = now.Minute;
var seconds = now.Second;
var ticks = now.Ticks;
Console.WriteLine($"Day: {day}\n" +
    $"Month: {month}\n" +
    $"Year: {year}\n" +
    $"Hour: {hour}\n" +
    $"Minute: {minute}\n" +
    $"Second: {seconds}\n" +
    $"Ticks: {ticks}");

var tomorrow = today.AddDays(1);
var yesterday = today.AddDays(-1);

Console.WriteLine($"Long date string: {now.ToLongDateString()}");
Console.WriteLine($"Short date string: {now.ToShortDateString()}");
Console.WriteLine($"Long time string: {now.ToLongTimeString()}");
Console.WriteLine($"Short time string: {now.ToShortTimeString()}");
Console.WriteLine(now.ToString());

// Format specifiers
Console.WriteLine($"Format specifiers: {now.ToString("yyyy-MMMM-dd dddd")}");

// TimeSpan
// Create
var timeSpan1 = new TimeSpan(1, 2, 3);

var timeSpan2 = new TimeSpan(1, 0, 0);
var timeSpan3 = TimeSpan.FromHours(1);

var start = DateTime.Now;
var end = DateTime.Now.AddMinutes(10);
var duration = end - start;
Console.WriteLine($"Duration: {duration}");

// Properties
Console.WriteLine($"Minutes: {timeSpan1.Minutes}");
Console.WriteLine($"Minutes: {timeSpan1.TotalMinutes}");

// Add
Console.WriteLine($"Add example: {timeSpan1.Add(TimeSpan.FromMinutes(8))}");
Console.WriteLine($"Subtract example: {timeSpan1.Subtract(TimeSpan.FromMinutes(2))}");

// ToString
var timeSpanToString = timeSpan1.ToString();
Console.WriteLine($"Time span to string: {timeSpanToString}");

// Parse
var timeSpanParse = TimeSpan.Parse("01:02:03");
Console.WriteLine($"Parse time span: {timeSpanParse}");
Console.WriteLine();

// ----- Text -----
Console.WriteLine("-----< Text >-----");
var fullName = "Ian Jordaan ";
Console.WriteLine($"Trim: {fullName.Trim()}");
Console.WriteLine($"ToUpper: {fullName.ToUpper()}");
Console.WriteLine($"ToLower: {fullName.ToLower()}");

var index = fullName.IndexOf(' ');
var firstName = fullName.Substring(0, index);
var lastName = fullName.Substring(index + 1);
Console.WriteLine($"FirstName: {firstName}");
Console.WriteLine($"LastName: {lastName}");

var names = fullName.Split(' ');
Console.WriteLine($"FirstName: {names[0]}");
Console.WriteLine($"LastName: {names[1]}");

Console.WriteLine($"Replace: {fullName.Replace("Ian", "Ian Arthur")}");

if (String.IsNullOrEmpty(fullName))
    Console.WriteLine("Invalid");

var str = "27";
var age = Convert.ToByte(str);
Console.WriteLine($"Age: {age}");

var price = 256.56f;
Console.WriteLine($"Currency: {price.ToString("C")}");
Console.WriteLine($"Currency: {price.ToString("C1")}");
Console.WriteLine($"Currency: {price.ToString("C0")}");

var sentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
const int maxLength = 40;

if (sentence.Length < maxLength)
    Console.WriteLine(sentence);

var words = sentence.Split(new char[] { ' ', ',', '.' });
var totalCharacters = 0;
var summaryWords = new List<string>();

foreach (var word in words)
{
    summaryWords.Add(word);

    totalCharacters += word.Length + 1;
    if (totalCharacters > maxLength)
    {
        break;
    }
}
var sumary = String.Join(" ", summaryWords) + "...";
Console.WriteLine(sumary);

var builder = new StringBuilder();
builder.Append('-', 10)
    .AppendLine()
    .Append("Header")
    .AppendLine()
    .Append('-', 10);

builder.Replace('-', '=');

builder.Remove(0, 10);

builder.Insert(0, new string('*', 10));

Console.WriteLine(builder);