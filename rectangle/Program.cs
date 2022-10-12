
Console.WriteLine("Введите длину прямоугольника");
int Lenght;

while (true)
{


    if (int.TryParse(Console.ReadLine(), out Lenght))
    {
        break;
    }
    else
    {
        Console.WriteLine("Введите правильное числовое значение");
    }
}

Console.WriteLine("Введите ширину прямоугольника");
int Width;

while (true)
{


    if (int.TryParse(Console.ReadLine(), out Width))
    {
        break;
    }
    else
    {
        Console.WriteLine("Введите правильное числовое значение");
    }
}

for (int a = 0; a < Lenght; a++)
{
    for (int i = 0; i < Width; i++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
