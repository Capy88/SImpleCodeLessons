using System.Diagnostics;

//Console.WriteLine($"введите кол-во студентов");
//string students = Console.ReadLine();

//int weightStudents;
//bool result = int.TryParse(students, out weightStudents);
//if (result == false)
//{
//    Console.WriteLine("некорректное значение");
//    Process.GetCurrentProcess().Kill();
//}

//int[] weight = new int[weightStudents];
List <int> weight = new List<int>();

for (int i = 1; ; i++)
{
    Console.WriteLine($"Введите вес {i} студента,затем введите любую букву для выхода");
    int WeightOfStudent;
    string b = Console.ReadLine();
    bool Result = int.TryParse(b, out WeightOfStudent);
    //weight[i] = WeightOfStudent;
    weight.Add(WeightOfStudent);
    if (Result == false)
    {
        Console.WriteLine("программа завершена");
        break;
    }

    //else if (a == int.Parse("q") )
    //{
    //    Console.WriteLine("программа завершена");
    //    Process.GetCurrentProcess().Kill();
    //}
}

int minWeight = weight[0];
int maxWeight = weight[0];

for (int i = 0; i < weight.Count; i++)
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








