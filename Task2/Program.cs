string number()
{
    Console.WriteLine("введите свое имя");
    string a = Console.ReadLine();
    string b = $"привет, {a}";
    return b;
}
string c = number();
Console.WriteLine(c);




Console.WriteLine("введите скорость в км/ч");
int km = int.Parse(Console.ReadLine());

Console.WriteLine("введите скорость в м/с");
int m = int.Parse(Console.ReadLine());

double kmm = m * 3.6;
Console.WriteLine($"скорость в километрах {km}");
Console.WriteLine($"скорость в метрах {m}");
Console.WriteLine($"переведенная скорость из м/с в км/ч {kmm}");
if (km > kmm)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($" скорость {km} больше скорости {kmm}");
    Console.ForegroundColor = ConsoleColor.White;
}
else if (km == kmm)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($" скорость {km} равна скорости {kmm}");
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($" скорость {kmm} больше скорости {km}");
    Console.ForegroundColor = ConsoleColor.White;
}
  



Console.WriteLine("введите  число 1");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("введите  число 2");
double b = double.Parse(Console.ReadLine());

double result = a + b;
Console.WriteLine(result);