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

string[] CreatingInputArray(int size)// аргумент - размер массива
{
    string[] inpArr = new string[size];
    for (int i = 0; i < size; i++)
    {
        inpArr[i] = AutoGenerationText(8);
    }
    return inpArr;
}

string answer = "cтрок, длина которых меньше либо \nравна 3 символам, не найдено → ";

string[] oldArray = CreatingInputArray(5);

string[] CreatOutputArray(string[] inpArr, int numS)//выбираем значения короче numS симв.
{
    string[] nArr = new string[1];
    int i = 0, j = 0;
    while (i < inpArr.Length)
    {
        if (inpArr[i].Length < numS)
        {
            nArr[j] = inpArr[i];
            j++;
            Array.Resize(ref nArr, nArr.Length + 1);
        }
        i++;
    }

    if (nArr.Length > 1) Array.Resize(ref nArr, nArr.Length - 1);
    if (nArr[0] != null) answer = $"cтрок, длина которых меньше либо \nравна 3 символам, найдено {nArr.Length} → ";
    return nArr;
}


string[] newArray = CreatOutputArray(oldArray,4);

Console.Clear();
Console.Write($"В исходном массиве → [{String.Join(",",oldArray)}]\n");
Console.Write($"{answer} ");
Console.Write("[");
Console.Write(String.Join(",", newArray));
Console.Write("]\n");