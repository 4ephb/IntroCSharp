// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): 
// Задайте одномерный массив, заполненный случайными числами. Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.
// Например:
// [1,2,3,4] -> средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами
// [2,3,5,7] -> средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами
// [1,2,5,4] -> средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами

Console.Clear();
Console.WriteLine($"Задайте одномерный массив, заполненный случайными числами. Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.");

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

int[] EvenOdd(int[] array, int rem)
{
    int ieven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) ieven = ieven + 1;
    }

    int iodd = array.Length - ieven;
    int[] evenArr = new int[ieven];
    int[] oddArr = new int[iodd];
    int j = 0;
    int k = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
        {
            evenArr[k] = array[i];
            k++;
        }

        else if (array[i] % 2 != 0)
        {
            oddArr[j] = array[i];
            j++;
        }

    if (rem == 2) return evenArr;
    else return oddArr;
}

double ArrayAverage(int[] array)
{
    double sum = 0;
    int ArLen = array.Length;

    if (ArLen > 0) 
    {
        for (int i = 0; i < ArLen; i++)
            sum += array[i];
    }
    else ArLen = 1;

    sum = sum / ArLen;
    return sum;
}

void DiffAverages(int ArrayAverageE, int ArrayAverageO)
{
    if (ArrayAverageE > ArrayAverageO || ArrayAverageO == 0)  Console.Write($"средн. арифм. значений элементов массива с чётными числами ({ArrayAverageE}) > средн. арифм. значений элементов с нечётными числами ({ArrayAverageO})");
    else if (ArrayAverageE < ArrayAverageO || ArrayAverageE == 0)  Console.Write($"средн. арифм. массива значений элементов с нечётными числами ({ArrayAverageO}) > средн. арифм. значений элементов с чётными числами ({ArrayAverageE})");
    else  Console.Write($"средн. арифм. значений элементов массива с нечётными числами ({ArrayAverageO}) = средн. арифм. значений элементов с чётными числами ({ArrayAverageE})");
}

int Size = 3;

int[] array = FillArray(Size, 1, 7);
ShowArray(array);

int[] EvenArray = EvenOdd(array, 2); // 2 - чётные числа
int[] OddArray = EvenOdd(array, 1); // 1 - нечётные числа

// Вывести чётный и нечётный массивы в консоль
// Console.Write($" -> ");
// ShowArray(EvenArray);
// ShowArray(OddArray);

int averageEven = Convert.ToInt32(ArrayAverage(EvenArray));
//Console.Write($"  [{averageEven}]");
int averageOdd = Convert.ToInt32(ArrayAverage(OddArray));
//Console.Write($" - [{averageOdd}]");

Console.Write($" -> ");
DiffAverages(averageEven, averageOdd);