// Домашнее задание
// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой):
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 х 2 х 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

// Ручной ввод
// Console.Write("Введите размер трёхмерного массива (x): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер трёхмерного массива (y): ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер трёхмерного массива (z): ");
// int k = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 2;
int n = 2;
int k = 2;

int maxUni = 89;
void Start()
{
    if (m * n * k <= maxUni)
    {
        Console.WriteLine($"Массив размером {m} х {n} х {k}");
        int[,,] array = Fill3DArray(m, n, k);
        Show3DArray(array);
    }
    else Console.WriteLine("Невозможно заполнить массив двухзначными неповторяющимися числами.");
}

int[,,] Fill3DArray(int m, int n, int k)
{
    int[,,] array = new int[m, n, k];
    int[] Values = new int[maxUni];
    int value = 10;
    for (int i = 0; i < Values.Length; i++)
        Values[i] = value++;

    int minIndex = 0;
    int valueIndex;
    for (int x = 0; x < array.GetLength(0); x++)
        for (int y = 0; y < array.GetLength(1); y++)
            for (int z = 0; z < array.GetLength(2); z++)
            {
                valueIndex = new Random().Next(minIndex, Values.Length);
                array[x, y, z] = Values[valueIndex];
                Values[valueIndex] = Values[minIndex];
                minIndex++;
            }
    return array;
}

void Show3DArray(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
                Console.Write($"{array[x, y, z]}({x},{y},{z}) ");
            Console.WriteLine();
        }
    }
}

Start();