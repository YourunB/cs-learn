string a = "abc";
string b = "a";
b += "bc";
Console.WriteLine("Строковые переменные a == b: " + (a == b));

decimal myD = 1.5m;
double x = (double)myD;
myD = (decimal)x;
Console.WriteLine("Это тип {0}", (9 * Math.PI).GetType()); //вернет тип System.Double