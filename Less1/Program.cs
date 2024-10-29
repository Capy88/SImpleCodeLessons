#region Задача 1
//Console.WriteLine("Введите два числа");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());

//TODO сделать обработку ошибку\
//if (a > b)
//{
//    Console.WriteLine($"{a} больше {b}");
//}
//else if (a < b)
//{
//    Console.WriteLine($"{a} меньше {b}");
//}
//else if (a == b)
//{
//    Console.WriteLine($"{a} равно {b}");
//}
#endregion

#region Задача 2
//int c = Convert.ToInt32(Console.ReadLine()); 
//if (c > 5 && c < 10)
//{
//    Console.WriteLine("Число больше 5 и меньше 10");
//}
//else
//{
//    Console.WriteLine("Неизвестное число");
//}
#endregion

#region Задача 3
Console.WriteLine("Введите сумму вклада");
int d = Convert.ToInt32(Console.ReadLine());
if (d < 100)
{
    Console.WriteLine($"Ваша сумма составит { d + d * 0.05}");
}
else if (d >= 100 && d <= 200)
{
    Console.WriteLine($"Ваша сумма составит {d + d * 0.07}");
}
else if (d > 200)
{
    Console.WriteLine($"Ваша сумма составит {d + (d / 100 * 10)}");
}
#endregion