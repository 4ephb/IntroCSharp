// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8 
// 12-> 2 
// 85 -> 8

Console.Clear();
Console.WriteLine("Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.");
int randomNum = new Random().Next(10, 100);
Console.WriteLine($"Число: {randomNum}");

int a1 = randomNum / 10;
int a2 = randomNum % 10;
int max = a1;

if (a2 > max) max = a2;
//int x = randomNum % 100 / 10;
Console.WriteLine($"Максимальная цифра: {max}");