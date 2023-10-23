
int sum(int a,int b)
{
    if (b == 0)
        return a;
    return sum(a + 1, b - 1);
}


Console.Write("Введите элемент: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(a,b));