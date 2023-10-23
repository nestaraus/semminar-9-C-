// Напишите программу котрая на вход будет принимать число и возвращать сумму его цифр


int sum(int a)
{
    if (a<10)
        return a;
    return sum(a/10)+a%10;
}


Console.Write("Введите элемент: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(a));