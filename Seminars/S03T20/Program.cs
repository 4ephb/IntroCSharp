// 20. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// Например:
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


Console.Clear();
Console.WriteLine("21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.");

// Пример 1
// int Ax = 3;
// int Ay = 6;
// int Bx = 2;
// int By = 1;

// Пример 2
// int Ax = 7;
// int Ay = -5;
// int Bx = 1;
// int By = -1;

// Ручной ввод
Console.Write("Введите Первую координату точки А: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Вторую координату точки А: ");
int Ay = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Первую координату точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Вторую координату точки B: ");
int By = Convert.ToInt32(Console.ReadLine());

double Sqr = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2));
Console.WriteLine($"Расстояние между точками A({Ax},{Ay}) и B({Bx},{By}) = {Math.Round(Sqr, 2)}");
