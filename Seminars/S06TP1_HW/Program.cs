// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): 
// Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.
// Например:
// [8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
// [8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо

Console.Clear();
Console.WriteLine($"Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.");

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

int[] ArrShift2(int[] array, int pos)
{
    int[] shift = new int[array.Length];

    int pos01 = 0;
    int pos02 = 0;
    int pos03 = 0;
    int pos04 = 0;
    int ShiftCorrect = Math.Abs(pos);

    if (ShiftCorrect > array.Length) ShiftCorrect = ShiftCorrect % array.Length;

    if (pos > 0)
    {
        pos01 = ShiftCorrect;
        pos03 = array.Length - ShiftCorrect;
    }
    else if (pos < 0)
    {
        pos02 = ShiftCorrect;
        pos04 = array.Length - ShiftCorrect;
    }
    else return array;

    for (int i = 0; i < ShiftCorrect; i++)
    {
        shift[i + pos04] = array[i + pos03];
    }

    for (int i = 0; i < array.Length - ShiftCorrect; i++)
    {
        shift[i + pos01] = array[i + pos02];
    }
    return shift;
}

int Size = 5;

int[] array = FillArray(Size, 1, 100);
ShowArray(array);

Console.Write($" -> ");

ShowArray(ArrShift2(array, -1)); // (-1) - сдвиг влево, (1) - сдвиг вправо, (0) - без сдвига. 