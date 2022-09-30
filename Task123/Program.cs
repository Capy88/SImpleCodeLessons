int[] a = { 60, 130, 74, 23, 4 };
int minvalue = a[0];
int maxvalue = a[0];
for (int i = 0; i < a.Length; i++)
{
    if (a[i] < minvalue)
    {
        minvalue = a[i];
    }
    if (a[i] > maxvalue)
    {
        maxvalue = a[i];
    }
}
Console.WriteLine(minvalue);
Console.WriteLine(maxvalue);