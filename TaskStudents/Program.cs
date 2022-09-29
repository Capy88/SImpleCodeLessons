Console.WriteLine("Ведите вес Максима");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите вес Данила");
int den = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите вес Ивана");
int ivan = int.Parse(Console.ReadLine());
if (max  > ivan * 2  )
{
    Console.WriteLine("Правда");
}
else if (den * 2 > ivan * 2)
{
    Console.WriteLine("Правда");
}
else if (ivan * 2 > max * 2)
{
    Console.WriteLine("Правда");
}

else if (ivan * 2 > den * 2)
{
    Console.WriteLine("Правда");
}

else if (max * 2 > den * 2)
{
    Console.WriteLine("Правда");
}

else if (den * 2 > max * 2)
{
    Console.WriteLine("Правда");
}
else
{
    Console.WriteLine("Ложь");
}
