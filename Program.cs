
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.Write("Input 3-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result;
if (number > 99 && number < 1000)
{
    result = number / 10 % 10;
    Console.WriteLine(result);
}
else
    Console.WriteLine("Not 3-digit number");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.Write("Input number: ");
long number = Math.Abs(Convert.ToInt64(Console.ReadLine()));
byte thirdDigit;
if (number < 100)
    Console.WriteLine("No 3rd digit");
else
{
    for (; number > 999; number = number / 10);
    thirdDigit = Convert.ToByte(number % 10);
    Console.WriteLine(thirdDigit);
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.Write("Input day of the week: ");
byte number = Convert.ToByte(Console.ReadLine());
if (number < 1 || number > 7)
    Console.WriteLine("It's not correct day");
else if (number > 5)
    Console.WriteLine("It's Weekend!");
else
    Console.WriteLine("Go to work");
*/





