// 0. Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.Clear();
Console.WriteLine("0. Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sqr = number * number;

Console.WriteLine($"Квадрат числа {number} равен {sqr}");
//Console.WriteLine("Квадрата числа " + number + " равен " + number * number);
//Console.WriteLine("Квадрата числа " + number + " равен " + Math.Pow(number, 2));