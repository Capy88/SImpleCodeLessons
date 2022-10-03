Console.WriteLine($"введите кол-во студентов");
string students = Console.ReadLine();
int weightStudents = int.Parse(students);

int[] weight = new int [weightStudents];

for (int i = 0;i < weightStudents ; i++)
{
    Console.WriteLine($"Введите вес {i} студента, введите 999 для выхода");
    string b = Console.ReadLine();
    int a = int.Parse(b);
    weight [i] = a;
    if (a == 999)
    {
        Console.WriteLine("end");
        break;
    }
}

int minWeight = weight[0];
int maxWeight = weight[0];

for (int i = 0; i < weight.Length; i++)
{

    if (weight[i] < minWeight)
    {
        minWeight = weight[i];
    }
    if (weight[i] > maxWeight)
    {
        maxWeight = weight[i];
    }
}

if (minWeight * 2 < maxWeight)
{
    Console.WriteLine("правда");
}
else
{
    Console.WriteLine("ложь");
}








