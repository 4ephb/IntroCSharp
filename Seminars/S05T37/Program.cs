// 37. Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();
Console.WriteLine($"37. Найти произведение пар чисел в одномерном массиве.");

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

int[] PairsProd(int[] array)
{
    int Len = 0;
    if (array.Length % 2 == 0) Len = array.Length / 2;
    else Len = array.Length / 2 + 1;
    int[] result = new int[Len];

    for (int i = 0; i < Len; i++)
        result[i] = array[i] * array[array.Length - i - 1];

    if (array.Length % 2 != 0) result[Len - 1] = array[array.Length / 2];
    return result;
}

// // Ручной ввод
// Console.Write("Введите размер массива: ");
// int Size = Convert.ToInt32(Console.ReadLine());

int Size = 5;
int[] array = FillArray(Size, 1, 5);

ShowArray(array);
Console.Write($" -> ");

int[] res = PairsProd(array);
ShowArray(res);