// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
//

Console.Clear();
Console.WriteLine("17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X != 0 и Y != 0 и выдаёт номер четверти плоскости, в которой находится эта точка.");
Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write($"Расположение точки ( {x} ; {y} ): ");

    if (x > 0 && y > 0) Console.Write("I координатная четверть.");
    else if (x < 0 && y > 0) Console.Write("II координатная четверть.");
    else if (x < 0 && y < 0) Console.Write("III координатная четверть.");
    else if (x > 0 && y < 0) Console.Write("IV координатная четверть.");
    else Console.Write("Центр оси координат.");