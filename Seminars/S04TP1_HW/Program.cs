// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): 
// Напишите программу, которая задаёт массив из 10 элементов, которые необходимо заполнить случайными значениями в диапазоне от -10 до 10 и найти максимальное значение среди них.
// Например:
// [-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
// [-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6
// [-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] -> 7

Console.Clear();
Console.WriteLine($"Напишите программу, которая задаёт массив из 10 элементов, которые необходимо заполнить случайными значениями в диапазоне от -10 до 10 и найти максимальное значение среди них.");

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

int ArrayMax(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}

// Ручной ввод
// Console.Write("Введите размер массива: ");
// int Size = Convert.ToInt32(Console.ReadLine());

int Size = 10;

int[] array = FillArray(Size, -10, 10);
ShowArray(array);
Console.Write($" -> ");

int Max = ArrayMax(array);
Console.WriteLine(Max);