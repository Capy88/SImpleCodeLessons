using System.Diagnostics;

List<int> weight = new List<int>();
string exit = "q";
bool inputedExit;
for (int i = 1; ; i++)
{
    Console.WriteLine($"Введите вес {i} студента,затем введите любую букву для выхода либо введите q для завершения программы");
    int WeightOfStudent;
    string inputstring = Console.ReadLine();
    bool Result = int.TryParse(inputstring, out WeightOfStudent);
    weight.Add(WeightOfStudent);
   

    if (Result == false)
    {
        break;
    }
    else if (inputstring == exit);
    {
        Console.WriteLine("программа завершена");
        Process.GetCurrentProcess().Kill();
    }
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








