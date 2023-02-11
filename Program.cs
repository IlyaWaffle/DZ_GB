int N;
Console.Write("Введите число: ");
bool flag = int.TryParse(Console.ReadLine()!, out N);

if (flag)
{
    if (N < 0)
        N *= -1;
    for (int i = 0, j = N - 1; i < N; i++, j--)
    {
        Console.Write($"{i}{j} ");
    }
}
else
    Console.Write("Неверный ввод");