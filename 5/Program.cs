// Задайте значения M и N. Напишите программу, кторая выведет число M в степени N.

int rec(int a, int b)
{
    if (b == 0)
        return 1;
    return rec(a,b-1) * a;
}





Console.Write("Введите элемент: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(a,b));