int[] array = new[] { 2, 6, 8, 9, 12, 66 };
int result = 0;
for (int i = 0; i < array.Length; i++)
{
	if (array[i] % 2 == 0)
	{
		result = result + array[i];
	}
}

Console.WriteLine(result);