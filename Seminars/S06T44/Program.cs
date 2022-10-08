// 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Например:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8	

Console.Clear();
Console.WriteLine($"44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.");

void FibNum(int a, int b, int n)
{
    Console.Write($"{n} -> {a} {b} ");
    int temp = 0;
    for (int i = 0; i < n - 2; i++)
    {
        temp = a + b;
        a = b;
        b = temp;
        Console.Write($"{b} ");
    }
}

int[] FibNumArr(int a, int b, int n)
{
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;
    for (int i = 2; i < n; i++) array[i] = array[i - 1] + array[i - 2];
    return array;
}

void ShowArray(int[] array)
{
    Console.Write(array.Length + " -> " + String.Join(" ", array));
}

// Console.Write("Первое число Фибоначчи: ");
// int first = Convert.ToInt32(Console.ReadLine());
int first = 0;

// Console.Write("Второе число Фибоначчи: ");
// int second = Convert.ToInt32(Console.ReadLine());
int second = 1;

Console.Write("Введите количество чисел Фибоначчи: ");
int n = Convert.ToInt32(Console.ReadLine());

int variant = new Random().Next(0, 2);
if (variant == 1) FibNum(first, second, n);
else ShowArray(FibNumArr(first, second, n));
//Console.Write($" {variant}");
