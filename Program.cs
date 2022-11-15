/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/

void ThreeNum(int num)
{
        if (num >= 100 && num < 1000)
    {
        int result = ((num % 100) - (num % 10)) /10;
        Console.Write($"Вторая цифра числа {result}"); 
    }
        else
    {
      Console.Write("Введите корректно трехзначное число "); 
    } 
}
    Console.Write("Введите трехзначное число ");
    int number = Convert.ToInt32(Console.ReadLine());
    ThreeNum (number);
