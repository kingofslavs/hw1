// Задание 1
Console.WriteLine("Введите день");
int day;
if (int.TryParse(Console.ReadLine(), out day) && day > 0 && day < 32)
{
    Console.WriteLine("Введите месяц");
    int month;
    if (int.TryParse(Console.ReadLine(), out month) && month > 0 && month < 13)
    {
        Console.WriteLine("Введите год");
        int year;
        if (int.TryParse(Console.ReadLine(), out year) && year > 0)
        {
            int dayOfWeek;

            if (month < 3)
            {
                year -= 1;
                month += 10;
            }
            else
            {
                month -= 2;
            }

            dayOfWeek = ((day + 31 * month / 12 + year + year / 4 - year / 100 + year / 400) % 7);
            if (dayOfWeek == 0)
            {
                Console.WriteLine("Воскресенье");
            }
            else if (dayOfWeek == 1)
            {
                Console.WriteLine("Понедельник");
            }
            else if (dayOfWeek == 2)
            {
                Console.WriteLine("Вторник");
            }
            else if (dayOfWeek == 3)
            {
                Console.WriteLine("Среда");
            }
            else if (dayOfWeek == 4)
            {
                Console.WriteLine("Четверг");
            }
            else if (dayOfWeek == 5)
            {
                Console.WriteLine("Пятница");
            }
            else if (dayOfWeek == 6)
            {
                Console.WriteLine("Суббота");
            }
        }
        else
        {
            Console.WriteLine("Введен некорректный год!");
        }
    }
    else
    {
        Console.WriteLine("Введен некорректный месяц!");
    }
}
else
{
    Console.WriteLine("Введен некорректный день!");
}


// Задание 2
Console.WriteLine("Введите число 1:");
int numberOne;
if (int.TryParse(Console.ReadLine(), out numberOne))
{
    Console.WriteLine("Введите число 2:");
    int numberTwo;
    if (int.TryParse(Console.ReadLine(), out numberTwo))
    {
        if (numberTwo != 0)
        {
            int result = numberOne % numberTwo;
            if (result == 0)
            {
                Console.WriteLine("Число чётно");
            }
            else
            {
                Console.WriteLine("Число нечётно, остаток: " + result);
            }
        }
        else
        {
            Console.WriteLine("Запрещено делить на ноль!");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение для числа 2");
    }
}
else
{
    Console.WriteLine("Вы ввели некорректное значение для числа 1");
}