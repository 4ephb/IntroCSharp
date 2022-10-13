// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой): 
// Вывести первые n строк треугольника Паскаля. Реализовать вывод в виде равнобедренного треугольника.
// N = 7 -> https://ibb.co/yWPZbG7

Console.Clear();
Console.WriteLine("Вывести первые n строк треугольника Паскаля. Реализовать вывод в виде равнобедренного треугольника.");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillPascalTriangle(int size)
{
    int[,] array = new int[size, 2 * size + 1];
    array[0, size] = 1;

    for (int row = 1; row < size; row++)
        for (int col = size - row; col <= size + row; col++)
            array[row, col] = array[row - 1, col - 1] + array[row - 1, col + 1];
    return array;
}

void ShowPascalTriangle(int[,] array)
{
    int size = array.GetLength(0);
    string[] arrayStr = new string[size];
    
    for (int i = 0; i < size; i++)
        for (int j = size - i; j <= size + i; j++)
            if (array[i, j] != 0) arrayStr[i] += $"{array[i, j]}";
            else arrayStr[i] += " ";

    int max = arrayStr[arrayStr.Length - 1].Length;
    int count;

    for (int i = 0; i < arrayStr.Length; i++)
    {
        count = (max - arrayStr[i].Length) / 2;
        for (int j = 0; j < count; j++)
            Console.Write(" ");
        Console.WriteLine(arrayStr[i]);
    }
}

int n = ReadInt("Введите количество строк (n) треугольника Паскаля: ");
int[,] PascalTr = FillPascalTriangle(n);
ShowPascalTriangle(PascalTr);
