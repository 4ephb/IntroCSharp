// Домашнее задание
// 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Например:
// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine($"38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[" + String.Join(", ", array) + "]");
}

int MaxMinDiff (int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    int res = max - min;
    return res;
}

int Size = 5;

int[] array = FillArray(Size, 1, 100);
ShowArray(array);

Console.Write($" -> ");

int dif = MaxMinDiff(array);
Console.WriteLine($"{dif}");