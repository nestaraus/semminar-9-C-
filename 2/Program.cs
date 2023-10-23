// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

string rec(int n)
{
    if (n == 0)
        return "";
    return rec(n - 1) + $"{n} ";
}


Console.Write("Введите элемент: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));