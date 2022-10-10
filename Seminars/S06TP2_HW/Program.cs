// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой): 
// Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и определить существует ли пара соседних элементов с одинаковыми значениями, при наличии такого элемента заменить его на уникакальное значение.
// Например:
// [1,2,3,3] -> [1,2,3,4]

Console.Clear();
Console.WriteLine($"Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и определить существует ли пара соседних элементов с одинаковыми значениями, при наличии такого элемента заменить его на уникакальное значение.");

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

int[] CompareElem(int[] array)
{
    int min = array[0];
    int max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }
    
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == array[i - 1])
        {
            array[i] = new Random().Next(min, max + 2);
            i--;
        }
    }
    return array;
}

// // // Примеры
// int[] array = { 1, 2, 3, 3 };
// int[] array = { 2, 2, 3, 3, 7 };
// int[] array = { 0, 0, 0, 0 };

int Size = 4;
int[] array = FillArray(Size, 1, 5);

ShowArray(array);
Console.Write($" -> ");
ShowArray(CompareElem(array));
