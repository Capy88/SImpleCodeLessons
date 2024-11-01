Console.WriteLine("Введите первое число");
string str = Console.ReadLine();
int x = int.Parse(str);

Console.WriteLine("Введите второе число");
str = Console.ReadLine();
int y = int.Parse(str);

int result = x + y;
Console.Write("Сумма двух чисел: ");
Console.WriteLine(result);
Console.WriteLine($"Разность двух чисел: {x - y}");
Console.WriteLine($"Произведение двух чисел: {x * y}");
Console.WriteLine($"Отношение двух чисел: {x / y}");