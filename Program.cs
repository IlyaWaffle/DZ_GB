int N;
Console.Write("Введите число: ");
bool flag = int.TryParse(Console.ReadLine()!, out N);

if (flag)
{
    if (N < 0)
        N *= -1;
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{i * 2} ");
    }
}
else
    Console.Write("Неверный ввод");