// 33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
Console.WriteLine($"33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.");

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int[] array)
{
    Console.WriteLine("[" + String.Join(", ", array)+ "]");
}

bool FindNum(int[] array, int search)
{
    foreach (int i in array) if (i == search) return true;
    return false;    
}

// Ручной ввод
Console.Write("Введите искомое число: ");
int S = Convert.ToInt32(Console.ReadLine()); // int S = 4;

int[] array = FillArray(10, -10, 10);
ShowArray(array);

Console.WriteLine($"Число {S} в массиве " + (FindNum(array, S) ? "" : "не ") + "присутствует.");