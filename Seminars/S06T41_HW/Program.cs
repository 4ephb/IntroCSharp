// Домашнее задание
// 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Например:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

Console.Clear();
Console.WriteLine($"41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");

Console.Write($"Введите количество чисел M: ");
int m = Convert.ToInt32(Console.ReadLine());

int PositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

void InputNum(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1}-e число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"\n{String.Join(", ", array)} -> {PositiveNum(array)}");
}

InputNum(m);