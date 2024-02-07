// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Пример
// m = 3, n = 2 -> A(m,n) = 29

string AckermannFunction(int m, int n)
{
    if (m == 0 && n >= 0)
    {
        n += 1;
        return $"{n}";
    }
    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AckermannFunction(m - 1, Convert.ToInt32(AckermannFunction(m, n - 1)));
    }
    return $"Error. Введено отричательное число.";
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"A({m}, {n}) = {AckermannFunction(m, n)}");