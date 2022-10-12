double qauntity = 10;
double price = 100;
double discount = 0.75;
double cost;
cost = qauntity >= 10 ? qauntity * price * discount : qauntity * price;
Console.WriteLine("стоимость товара = " + cost);


Console.WriteLine("размеры стаканчиков: 1 - маленький, 2 - средний, 3 - большой");
string size = Console.ReadLine();
int costCoffee = 0;
switch (size)
{
	case "1":
		{

            costCoffee = 25;
			break;
		}
    case "2":
        {

            costCoffee = 50;
            break;
        }
    case "3":
        {

            costCoffee = 75;
            break;
        }
    default:
        {
            Console.WriteLine("введите правильное значение");
            break;
        }
}
if (costCoffee != 0)
{
    Console.WriteLine($"внесите {costCoffee} рублей");
}
else
{
    Console.WriteLine("пожалуйста, повторите выбор");
}