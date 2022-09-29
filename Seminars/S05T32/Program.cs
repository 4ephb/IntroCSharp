// 32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// Например:
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();
Console.WriteLine($"32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.");

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[" + String.Join(", ", array)+ "]");
}

void ReverseArrayValues(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int[] numbers = FillArray(4, -4, 9);
ShowArray(numbers);

Console.Write(" -> ");

ReverseArrayValues(numbers);
ShowArray(numbers);
