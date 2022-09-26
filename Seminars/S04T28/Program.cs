// 28. Напишите программу, которая принимает на вход число N и M и выдаёт произведение чисел от M до N.
// Например:
// 2,4 -> 24 
// 1,5 -> 120

Console.Clear();
Console.WriteLine("28. Напишите программу, которая принимает на вход число N и M и выдаёт произведение чисел от M до N.");

int ProdNumb(int num1, int num2)
{
    int S = 1;
    for (int i = num1; i <= num2; i++)
    {
        S = S * i;
    }
    return S;
}

Console.Write("Ведите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(N) > Math.Abs(M))
{
    int x = Math.Abs(N);
    N = Math.Abs(M);
    M = x;
}
else
{
    N = Math.Abs(N);
    M = Math.Abs(M);
}

Console.WriteLine($"Произведение чисел от {N} до {M} равно {ProdNumb(N, M)}.");