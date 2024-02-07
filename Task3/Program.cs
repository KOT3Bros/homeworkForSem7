// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void PrintReverseArray(int[] array, int i)
{
    if (i != array.Length)
    {
        Console.Write($"{array[i]} ");
    }
    if (i > 0 && i < array.Length)
    {
        PrintReverseArray(array, i - 1);
    }
}

int[] array = { 1, 2, 5, 0, 10, 34 };
int i = array.Length - 1;
PrintReverseArray(array, i);