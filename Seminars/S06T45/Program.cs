// 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();
Console.WriteLine($"45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.");

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

int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        copy[i] = array[i];
    return copy;
}

int Size = 5;
int[] array = FillArray(Size, 1, 100);

ShowArray(array);
Console.Write($" -> ");
ShowArray(CopyArray(array));