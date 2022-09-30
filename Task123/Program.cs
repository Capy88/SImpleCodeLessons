int[] weight = { 65, 140,74 };

Console.WriteLine($"вес Максима = {weight[0]}");
Console.WriteLine($"вес Ильи = {weight[1]}");
Console.WriteLine($"вес Егора = {weight[2]}");

int minValue = weight[0];
int maxValue = weight[0];

for (int i = 0; i < weight.Length; i++)
{
    if (weight[i] < minValue)
    {
        minValue = weight[i];
    }
    if (weight[i] > maxValue)
    {
        maxValue = weight[i];
    }
}
 
if (minValue * 2 < maxValue )   
{
    Console.WriteLine("правда");
}
else
{
    Console.WriteLine("ложь");
}








