// Домашнее задание
// 29. Программа, которая задаёт массив из N элементов и выводит их на экран.
// Например:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("29. Программа, которая задаёт массив из N элементов и выводит их на экран.");

int[] FillArr(int len, int min, int max)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max + 1);
    return array;
}

// Пример 1
// int N = 5;
// int Min = 1;
// int Max = 19;

// Пример 2
// int N = 3;
// int Min = 1;
// int Max = 33;

// Ручной ввод
// Console.Write("Введите количество элементов массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите начальное значение диапазона массива: ");
// int Min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конечное значение диапазона массива: ");
// int Max = Convert.ToInt32(Console.ReadLine());

// Генеративный ввод
int N = new Random().Next(5, 31); // Генерация размера массива от 5 до 30.
int Min = new Random().Next(-50, 51); // Генерация начального часла для генерируемого диапазона {min} (от -50 до 50).
int Max = new Random().Next(51, 100); // Генерация конечного числа для генерируемого диапазона {max} (от 51 до 99).

int[] res = FillArr(N, Min, Max);
Console.WriteLine($"Массив из {res.Length} элементов числового диапазона от {Min} до {Max}:");
Console.WriteLine($"[{String.Join(", ", res)}]");
