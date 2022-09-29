// 35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
// Пример для массива из 5, а не из 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();
Console.WriteLine($"35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].");

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int[] array)
{
    Console.WriteLine("[" + String.Join(", ", array) + "]");
}

int ArrayValCount(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max) count++;
    }
    return count;
}

int Size = 123;
int Min = 10;
int Max = 99;

int[] array = FillArray(Size, -(Size/2), Size * 2); // int[] array = FillArray(123, -61, 246);
ShowArray(array);

Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [{Min}, {Max}] равно {ArrayValCount(array, Min, Max)}.");

