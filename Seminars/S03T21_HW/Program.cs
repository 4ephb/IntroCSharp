// Домашнее задание
// 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Например:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

// Пример 1
// int Ax = 3;
// int Ay = 6;
// int Az = 8;
// int Bx = 2;
// int By = 1;
// int Bz = -7;

// Пример 2
// int Ax = 7;
// int Ay = -5;
// int Az = 0;
// int Bx = 1;
// int By = -1;
// int Bz = 9;

// Ручной ввод
Console.Write("Введите Первую координату точки А: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Вторую координату точки А: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Третью координату точки А: ");
int Az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Первую координату точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Вторую координату точки B: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Третью координату точки B: ");
int Bz = Convert.ToInt32(Console.ReadLine());

double Sqr = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2));
Console.WriteLine($"Расстояние между точками A({Ax},{Ay},{Az}) и B({Bx},{By},{Bz}) равно {Math.Round(Sqr, 2)}.");
