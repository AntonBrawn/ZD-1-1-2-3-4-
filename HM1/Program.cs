// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

using System;
using static System.Console;
Clear();
Write("Введите пожалуйста первое число:");
int number=Convert.ToInt32(ReadLine());
Write("Введите пожалуйста второе число:");
int number1=Convert.ToInt32(ReadLine());
{
if ((number>number1))
    {WriteLine("Первое число  больше второго!"); Write("Max="); WriteLine((number)); Write("Min="); WriteLine(number1); Write("Max>Min");
    return;
}
        if (( number<number1))
        {WriteLine("Второе число больше первого!"); Write("Min="); WriteLine(number); Write("Max="); WriteLine(number1); Write("Min<Max");
        return;
        }
            else 
            {WriteLine("Ошибка!Введенные вами числа одинаковые.Попробуйте ввести другие числа."); Write(number); Write("="); Write(number1);
            return;
            }
}