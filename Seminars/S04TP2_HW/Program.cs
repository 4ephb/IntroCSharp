// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой): 
// Напишите программу, которая задаёт 2 одномерных массива из N элементов которые заполняются случайными значениями в диапазоне от 1 до 10 и находит среднее арифметическое элементов этих 2 массивов, далее от большего из получившихся средних арифметических отнимаем меньшее и округлённый до целого числа результат переводим в двоичную систему счисления.
// Например:
// [1,2,3,4] [3,6,4] -> округлённая до целого числа разница между средними арифметическими массивов = 2. 2 в двоичной системе счисления = 10
// [4,7,9] [3,3,1,2,2] -> округлённая до целого числа разница между средними арифметическими массивов = 4. 4 в двоичной системе счисления = 100

Console.Clear();
Console.WriteLine($"Напишите программу, которая задаёт 2 одномерных массива из N элементов которые заполняются случайными значениями в диапазоне от 1 до 10 и находит среднее арифметическое элементов этих 2 массивов, далее от большего из получившихся средних арифметических отнимаем меньшее и округлённый до целого числа результат переводим в двоичную систему счисления.");

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[" + String.Join(", ", array) + "]");
}

int RandomSize(int min, int max)
{
    int size = new Random().Next(min, max + 1);
    return size;
}

double ArrayAverage(int[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum += array[i];

    sum = sum / array.Length;
    return sum;
}

int DiffAverages(int ArrayAverage1, int ArrayAverage2)
{
    int diff = 0;
    if (ArrayAverage1 < ArrayAverage2) diff = ArrayAverage2 - ArrayAverage1;
    else diff = ArrayAverage1 - ArrayAverage2;
    return diff;
}

string DigitToBinary(int bin)
{
    string res = Convert.ToString(bin, 2);
    return res;
}

int Size = RandomSize(1, 5);
int[] array1 = FillArray(Size, 1, 10);
ShowArray(array1);

Size = RandomSize(6, 13);
int[] array2 = FillArray(Size, 1, 10);
ShowArray(array2);

Console.Write($" -> ");

int average1 = Convert.ToInt32(ArrayAverage(array1));
//Console.Write($"[{average1}]");
int average2 = Convert.ToInt32(ArrayAverage(array2));
//Console.Write($"[{average2}]");

int difference = DiffAverages(average1, average2);
string binary = DigitToBinary(difference);

Console.Write($"округлённая до целого числа разница между средними арифметическими массивов = {difference}. {difference} в двоичной системе счисления = {binary}");