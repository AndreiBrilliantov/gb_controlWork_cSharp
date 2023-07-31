/*
Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо 
равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении 
не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

bool CheckLenItem(string item, int maxLen) {
    return item.Count() <=  maxLen ? true : false;
}

string[] AppendItem(string[] array, string item) {
    
    if(array == null)
        return new string[] {item};
    
    int arrayLen = array.Length;
    string[] returnArray = new string[arrayLen + 1];
    for (int i = 0; i < arrayLen; i++)
    {
        returnArray[i] = array[i];
    }
    returnArray[arrayLen] = item;

    return returnArray;
}

string[] GetEl(string[] arr, int maxLen) {
    string[] retArr = new string[0];
    foreach (string item in arr)
    {
        if (CheckLenItem(item, maxLen))
        {
            retArr = AppendItem(retArr, item);
        }
    }
    return retArr;
    
}

string[] words = { "Russia", "Denmark", "Kazan" };
string[] newWords = GetEl(words, 3);
Console.WriteLine($"[\"{string.Join("\", \"", words)}\"] → [\"{string.Join("\", \"", newWords)}\"]");