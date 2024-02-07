// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

string PrintNumbers(int m, int n)
{
    if (m <= n)
    {
        if (n < 1)
        {
            return " отсутствуют";
        }
        else if (n == 1 || n == m)
        {
            return $": {n}";
        }
        return $"{PrintNumbers(m, n - 1)}, {n}";
    }
    if (m < 1)
    {
        return " отсутствуют";
    }
    return $"{PrintNumbers(n, m - 1)} {m}";
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m <= n)
{
    Console.Write($"Натуральные числа в промежутке от {m} до {n}");
}
else
{
    Console.Write($"Натуральные числа в промежутке от {n} до {m}");
}
Console.WriteLine(PrintNumbers(m, n));