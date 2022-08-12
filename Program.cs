
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
void showSecondDigit(int number)
{
    int result;
    if (number > 99 && number < 1000)
    {
        result = number / 10 % 10;
        Console.WriteLine(result);
    }
    else
        Console.WriteLine("Not 3-digit number");
}

Console.Write("Input 3-digit number: ");
showSecondDigit(Math.Abs(Convert.ToInt32(Console.ReadLine())));
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
void showThirdDigit (int number)
{
    byte thirdDigit;
    if (number < 100)
        Console.WriteLine("No 3rd digit");
    else
    {
        for (; number > 999; number = number / 10);
        thirdDigit = Convert.ToByte(number % 10);
        Console.WriteLine(thirdDigit);
    }
}
Console.Write("Input number: ");
showThirdDigit(Math.Abs(Convert.ToInt32(Console.ReadLine())));
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool weekend (int number)
{
    return number == 6 || number == 7;
}

Console.Write("Input day of the week: ");
Console.WriteLine(weekend(Convert.ToInt32(Console.ReadLine())));
*/






