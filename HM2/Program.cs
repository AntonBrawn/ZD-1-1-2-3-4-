//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


using System;
using static System.Console;
Clear();
Write("Введите пожалуйста первое число:");
int number1=Convert.ToInt32(ReadLine());
Write("Введите пожалуйста второе число:");
int number2=Convert.ToInt32(ReadLine());
Write("Введите пожалуйста третье число:");
int number3=Convert.ToInt32(ReadLine());
{
if((number1>number2))
    {
     int max_1=number1;
     if ((max_1>number3))
     {WriteLine("Максимальное число из 3 возможных"); Write(max_1);
     return;}
    }
    
    if ((number1<number2))
        {
         int max_2=number2;
         if((max_2>number3))
         {WriteLine("Максимальное число из 3 возможных"); Write(max_2);
         return;}
        }
        
          if ((number1<number3))
             {
              int max_3=number3;
              if((max_3>number2))
              {WriteLine("Максимальное число из 3 возможных"); Write(max_3);
              return;}
             }
          else
              {
                 WriteLine("Все 3 числа одинаковые , Ошибка :(( !");
              } 
                
                
}        
