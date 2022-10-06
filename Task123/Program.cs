

List<int> studentsWeight = new List<int>();
bool inputedExit = false; //переменная означающая, что пользователь захотел завершить программу при вводе данных



while (true)
{
    Console.WriteLine($"Введите вес {studentsWeight.Count + 1} студента или введите 'q' для завершения программы или любую другую букву для окончания ввода информации о студентах");
    string inputstring = Console.ReadLine();

    if(inputstring == "q")
    {
        inputedExit = true; //Эта переменная потом проверяется ниже и если она true, то программа больше ничего не делает
        break;
    }
    

    int weightOfStudent;
    bool inputIsNumber = int.TryParse(inputstring, out weightOfStudent); // Проверяем, что ввел число, а не другой символ

    if(inputIsNumber == false) //и выходим из ввода весов если ввел не числа
    {
        break;
    }
    

    studentsWeight.Add(weightOfStudent);
}

Console.WriteLine("введите во сколько раз самый больший вес должен быть больше самого минимального веса");
string multiplyString = Console.ReadLine();
int multiplyWeight = int.Parse(multiplyString);

if (inputedExit)
{
    Console.WriteLine("Вы завершили работу с программой. Программа будет закрыта после нажатия на любую клавишу");
}
else
{
    if (studentsWeight.Count < 2)
    {
        Console.WriteLine("Нужно ввести хотя бы 2х студентов, чтобы ответить на вопрос задачи");
    }
    else
    {

        CompareMinAndMax(studentsWeight);
        //Вынес код в отдельную функцию, чтобы было более читабельно и понятно читать код
        //Чтоб код умещался на одном экране так сказаить, а код функции уже можно было смотреть отдельно
        //И название функции уже говорит о том, что делает функция и внутрь нее даже можно не заглядывать, чтобы понять что она делает
    }

}




//Эта функция выполняет одно конкретное действие - из принимаемого снаружи массива чисел находит максимальное и минимальное и сравнивает их
void CompareMinAndMax(List<int> studentsWeight)
{
    int minWeight = studentsWeight[0];
    int maxWeight = studentsWeight[0];

    for (int i = 0; i < studentsWeight.Count; i++)
    {

        if (studentsWeight[i] < minWeight)
        {
            minWeight = studentsWeight[i];
        }
        if (studentsWeight[i] > maxWeight)
        {
            maxWeight = studentsWeight[i];
        }
    }

    if (minWeight * multiplyWeight < maxWeight)
    {
        Console.WriteLine($"Вес самого тяжелого больше чем в {multiplyWeight} раза больше наименьшего веса");
    }
    else
    {
        Console.WriteLine($"Вес самого тяжелого не в {multiplyWeight} раза больше наименьшего веса");
    }
}

