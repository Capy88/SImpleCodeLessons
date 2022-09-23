int GetNumber(int num)
{
    Console.WriteLine($"Введите {num} число");
    string inputNumber1 = Console.ReadLine();
    int number1;
    bool isSuccess = int.TryParse(inputNumber1, out number1);
    while (isSuccess == false)
    {
        Console.WriteLine("Введите цифру");
        inputNumber1 = Console.ReadLine();

        isSuccess = int.TryParse(inputNumber1, out number1);
    }

    return number1;
}


int num1 = GetNumber(1); 

int num2 = GetNumber(2);

int num3 = GetNumber(3);    
if (num1 > num3)
{
    Console.WriteLine($"число {num1} больше числа {num3}");
}
else if (num1 == num3)
{
    Console.WriteLine($"число {num1} равно числу {num3}");
}
else
{
    Console.WriteLine($"число {num3} больше числа {num1}");
}

