// Домашнее задание
// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Например:
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");

// Ручной ввод
// Console.Write("Введите положительное значение m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите положительное значение n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 3,
    n = 2;

int AkkermanFn(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AkkermanFn(m - 1, 1);
    else return AkkermanFn(m - 1, AkkermanFn(m, n - 1));
}

int res = AkkermanFn(m, n);
Console.Write($"m = {m}, n = {n} -> A(m,n) = {res}");
