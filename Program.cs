/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

void TwoNum(int num)
{
        if (num >= 100 && num < 1000)
    {
        int result = ((num / 10) % 10);
        Console.Write($"Вторая цифра числа {result}"); 
    }
        else
    {
      Console.Write("Введите корректно трехзначное число "); 
    } 
}
    Console.Write("Введите трехзначное число ");
    int number = Convert.ToInt32(Console.ReadLine());
    TwoNum (number);
 
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет.
   
void ThirdDigit(int number)
{
    int result = 1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
            result = number % 10;
            Console.Write($"Третья цифра числа {result}"); 
    }
    else
        {
            Console.Write("Третьей цифры нет "); 
        } 
}
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
ThirdDigit (num);

Задача 15: Напишите программу, которая на вход принимает цифру, 
обозначающую день недели и проверяет, является ли этот день выходным.
*/ 
void Weekend(int num)
{
    if (num >= 1 && num < 6)
    {
        Console.Write("Это будний день :( ");
    }
    else if (num >= 6 && num < 8)
    {
        Console.Write("Это выходной день :) ");
    }
    else
    {
        Console.Write("Разве столько дней в неделе?)");
    }
}
Console.Write("Введите число соответствующее количеству дней в неделе ");
int number = Convert.ToInt32(Console.ReadLine());
Weekend (number);
