// Домашнее задание
// 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Например:
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine($"34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");

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

int EvenArrayNum(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) even++;
    return even;
}

int Size = 5;

int[] array = FillArray(Size, 100, 999);
ShowArray(array);

Console.Write($" -> ");

int evenNum = EvenArrayNum(array);
Console.Write($"{evenNum}");