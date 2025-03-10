using System.Text;

//-------------------------------------------------------------------------------------------------
string a = "abc";
string b = "a";
b += "bc";
Console.WriteLine("Строковые переменные a == b: " + (a == b));
Console.WriteLine("Объекты со строками a == b: " + ((object)a == (object)b));

//-------------------------------------------------------------------------------------------------
decimal myD = 1.5m;
double x = (double)myD;
myD = (decimal)x;
Console.WriteLine("Это тип {0}", (9 * Math.PI).GetType()); //вернет тип System.Double

//-------------------------------------------------------------------------------------------------
Console.OutputEncoding = Encoding.GetEncoding("utf-8");
decimal val = 70.2805m;
Console.WriteLine("{0:C4}", val); // C - денежный формат ( 4 - количество символов после запятой)

//-------------------------------------------------------------------------------------------------
double cost = 1432.54;
Console.WriteLine(cost.ToString("C", new System.Globalization.CultureInfo("en-US")));// Отображение с указанием локализации в методе ToString
string[] cultureNames = { "en-US", "fr-FR", "de-DE", "ru-RU" };
double value = 5165.32;
foreach (string name in cultureNames)
{
    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo(name);
    string output = String.Format(culture, "{0,-11} {1:C2}", culture.Name, value);// Отображение с форматированием методом String.Format
    Console.WriteLine(output);
}

//-------------------------------------------------------------------------------------------------
int count = 0;

do
{
    Console.WriteLine(count);
    count++;
}
while (count < 5);

//-------------------------------------------------------------------------------------------------
int[] fib = new int[] { 0, 1, 2, 3, 5 };

foreach (int i in fib)
{
    System.Console.WriteLine(i);
}