﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

using System;
using static System.Console;
Clear();
Write("Введите число N:");
int N=Convert.ToInt32(ReadLine());
{
    {
    for (int a = 1; a < N; a++)       
    if (a%2==0)            
    WriteLine(a);
    }
}