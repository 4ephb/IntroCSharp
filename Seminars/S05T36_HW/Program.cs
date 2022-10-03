// Домашнее задание
// 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Например:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine($"36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");

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

int SumDigit(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 0) sum = sum + array[i]; 
    return sum;
}

int Size = 5;

int[] array = FillArray(Size, -5, 10);
ShowArray(array);

Console.Write($" -> ");

int sum = SumDigit(array);
Console.WriteLine($"{sum}");