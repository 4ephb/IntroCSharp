// 30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// Например:
// [1,0,1,1,0,1,0,0]

Console.Clear();
Console.WriteLine("30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.");

int[] setArr(int len, int min, int max)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max);
    return array;
}

int[] array = setArr(8, 0, 2);
Console.WriteLine($"[{String.Join(",", array)}]");