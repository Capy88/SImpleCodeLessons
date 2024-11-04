
while (true) 
{
    static int GetNumber(string text)
    {
        Console.WriteLine(text);
        while (true)
        {
            string str = Console.ReadLine();
            int result;
            if (int.TryParse(str, out result))
                return result;
            else
                Console.WriteLine("Неправильный формат, пожалуйста введите корректное число");
        }

    }
    int x = GetNumber("Введите первое число");
    int y = GetNumber("Введите второе число");
    Console.WriteLine("Введите операцию: +,-,*,/, max, min");
    string cmd = Console.ReadLine();
    int GetResult(int x, int y, string cmd)
    {
        int result = 0;
        switch (cmd)
        {
            case "+":
                result = x + y;
                break;
            case "-":
                result = x - y;
                break;
            case "*":
                result = x * y;
                break;
            case "/":
                result = x / y;
                break;
        }
        if (cmd == "max")
            result = x;
        else if (cmd == "min")
            result = y;
        return result;
    }

    int result = GetResult(x, y, cmd);

    Console.WriteLine(result);
    Console.WriteLine("Хотите ли вы продолжить? Выберите Да или Нет");
    string str = Console.ReadLine();
    if (str == "да")
    {
        continue;
    }
    else if (str == "нет")
        break;
}

    

