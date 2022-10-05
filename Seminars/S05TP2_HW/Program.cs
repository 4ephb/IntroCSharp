// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой): 
// Задайте одномерный массив из N элементов, заполненный случайными числами. Необходимо определить, в какой последовательности заданы элементы массива: по возрастанию, по убыванию, хаотично, или все элементы одинаковы.
// Например:
// [1,2,3,4] -> по возрастанию
// [4,3,2,1] -> по убыванию
// [4,2,3,1] -> хаотично
// [1,1,1,1] -> все элементы равны

Console.Clear();
Console.WriteLine($"Задайте одномерный массив из N элементов, заполненный случайными числами. Необходимо определить, в какой последовательности заданы элементы массива: по возрастанию, по убыванию, хаотично, или все элементы одинаковы.");

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

void SequenceNumb(int[] array)
{
    int countE = 1;
    int countD = 1;
    int countEq = 1;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i - 1] <= array[i]) countE = countE + 1;
        if (array[i - 1] >= array[i]) countD = countD + 1;
        if (array[i - 1] == array[i]) countEq = countEq + 1;
    }

    if (countE == array.Length && countEq != countE) Console.Write("по возрастанию");
    else if (countD == array.Length && countEq != countD) Console.Write("по убыванию");
    else if (countEq == array.Length) Console.Write("все элементы равны");
    else Console.Write("хаотично");
}

// Примеры
int[] a = { 1, 2, 3, 4 }; // [1,2,3,4] -> по возрастанию
int[] b = { 4, 3, 2, 1 }; // [4,3,2,1] -> по убыванию
int[] c = { 4, 2, 3, 1 }; // [4,2,3,1] -> хаотично
int[] d = { 1, 1, 1, 1 }; // [1,1,1,1] -> все элементы равны

int Size = 4;
int[] array = FillArray(Size, 1, 4);

ShowArray(array); // для проверки примеров подставить a, b, c, d вместо array
Console.Write($" -> ");
SequenceNumb(array); // для проверки примеров подставить a, b, c, d вместо array
