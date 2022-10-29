/* Итоговая работа
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["Hello", "2", "world", ":-)"] → [“2”, “:-)”]
["1234", "1567", "-2", "computer science"] → [“-2”]
["Russia", "Denmark", "Kazan"] → [] 
*/
int numbLeters = 3;
string answer = $"cтрок, длина которых меньше либо \nравна {numbLeters} символам, не найдено → ";
string[] oldArray = new string[5];
string[] newArray = new string[1];

string AutoGenerationText(int maxChar)
{
    string result = "";
    int numberCharacters = new Random().Next(1, maxChar);
    while (result.Length < numberCharacters)
    {
        int chKod = new Random().Next(48, 123);
        if (chKod >= 48 && chKod <= 57 ||
            chKod >= 65 && chKod <= 90 ||
            chKod >= 97 && chKod <= 122
           ) result += (char)chKod;
    }

    return result;
}

void CreatingInputArray(string[] inpArr)// 
{
    int size = inpArr.Length;
    for (int i = 0; i < size; i++)
    {
        inpArr[i] = AutoGenerationText(8);
    }
}

void CreatOutputArray(string[] inpArr, int numS)//выбираем значения короче numS симв.
{
    int i = 0, j = 0;
    while (i < inpArr.Length)
    {
        if (inpArr[i].Length < numS + 1)
        {
            newArray[j] = inpArr[i];
            j++;
            Array.Resize(ref newArray, newArray.Length + 1);
        }
        i++;
    }

    if (newArray.Length > 1) Array.Resize(ref newArray, newArray.Length - 1);
    if (newArray[0] != null) answer = $"cтрок, длина которых меньше либо \nравна {numbLeters} символам, найдено {newArray.Length} → ";
}

CreatingInputArray(oldArray);

CreatOutputArray(oldArray, numbLeters);

Console.Clear();
Console.Write($"В исходном массиве → [{String.Join(",", oldArray)}]\n");
Console.Write($"{answer} ");
Console.Write("[");
Console.Write(String.Join(",", newArray));
Console.Write("]\n");