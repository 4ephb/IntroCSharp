// 39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Clear();
Console.WriteLine($"39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)");

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[" + String.Join(" ", array) + "]");
}

int[] FlipArray(int[] array)
{
    int X;
    for (int i = 0; i < array.Length/2; i++)
    {
        X = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = X;
    }
    return array;
}

int[] FlipArray2(int[] array)
{
    int[] reverse = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        reverse[i] = array[array.Length - i - 1];
    }
    return reverse;
}

// Примеры
int[] a = { 1, 2, 3, 4, 5 }; // [1 2 3 4 5] -> [5 4 3 2 1]
int[] b = { 6, 7, 3, 6 }; // [6 7 3 6] -> [6 3 7 6]

// Ручной ввод
// Console.Write("Введите размер массива: ");
// int Size = Convert.ToInt32(Console.ReadLine());

int Size = 5;
int[] array = FillArray(Size, 1, 5);

ShowArray(array); // для проверки примеров подставить a, b, вместо array
Console.Write($" -> ");

int[] flipArr;
int variant = new Random().Next(0, 2);
if (variant == 1) flipArr = FlipArray(array); // для проверки примеров подставить a, b, вместо array
else flipArr = FlipArray2(array); // для проверки примеров подставить a, b, вместо array

ShowArray(flipArr); 
//Console.WriteLine($" {variant}");