﻿// Задайте значения M и N. Напишите программу, кторая выведет все натуральные числа в промежутке от M до N.


string rec(int m, int n)
{
    if (n == m)
        return  $"{m} ";
    return rec(m, n - 1) + $"{n} ";
}





Console.Write("Введите элемент: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m,n));