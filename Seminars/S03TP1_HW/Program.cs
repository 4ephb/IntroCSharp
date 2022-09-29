// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): 
// Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
// Например:
// 10 -> 4
// 20 -> 7
// 30 -> 8

Console.Clear();
Console.WriteLine("Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга.");
Console.Write("Введите радиус круга: ");
int R = Convert.ToInt32(Console.ReadLine());

double CircleArea(int r)
{
    double result = Math.PI * Math.Pow(r, 2);
    return result;
}

int BigNumb(double r)
{
    int result = Convert.ToInt32(Math.Round(r));
    int max = result % 10;
    int k = result / 10;

    for (int i = 0; i <= result; i++)
    {
        k = (k / 10) % 10;
        if (max <= k) max = k;
    }
    return max;
}

double P = CircleArea(R);
Console.WriteLine($"Округленная площадь круга {Math.Round(P)}");
Console.WriteLine($"Максимальная цифра из округленной площади круга {BigNumb(P)}");