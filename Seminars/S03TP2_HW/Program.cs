// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой): 
// Напишите программу, которая на вход принимает букву, необходимо создать массив из 5 названий городов, и вывести на экран те (тот), где чаще всего встречается введённая буква.
// Например:
// Введённая буква: "о", массив ("Москва", "Тюмень", "Новосибирск") -> "Новосибирск"

#nullable disable warnings
Console.Clear();
Console.WriteLine("Напишите программу, которая на вход принимает букву, необходимо создать массив из 5 названий городов, и вывести на экран те (тот), где чаще всего встречается введённая буква.");

Console.Write("Введите букву: ");
char R = Convert.ToChar(Console.ReadLine());

string[] City = { "Москва", "Тюмень", "Новосибирск", "Владивосток" };
int countMax = 0;
int imax = 0;

Console.Write($"Введённая буква: \"{R}\", массив (");

for (int i = 0; i < City.Length; i++)
{
    string Slovo = Convert.ToString(City[i]);
    int count = 0;

    for (int j = 0; j < City[i].Length; j++)
    {
        char S = Convert.ToChar(Slovo[j]);
        if (Char.ToLower(S) == Char.ToLower(R))
        {
            count++;
            if (countMax < count) 
            {
                countMax = count;
                imax = i;
            }
        }

    }
}   
string[] cityList = City;
Console.Write($"\"{String.Join("\", \"", cityList)}\") -> \"{City[imax]}\".");
