// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

string[] CutUntilThree(string[] inArray)
{
    string[] result = new string[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {
            result[i] = inArray[i];
        }
    }
    return result;
}

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] != null)
        {
            Console.Write($"{inArray[i]}, ");
        }
    }
}

string[] someArray = { "Hello", "123", "function", "Find", "-2", "0", "random", "Sun" };
string[] newArray = CutUntilThree(someArray);

Console.Write("Изначальный массив: ");
PrintArray(someArray);
Console.WriteLine();

Console.Write("Массив с элементами длиной не более трёх символов: ");
PrintArray(newArray);