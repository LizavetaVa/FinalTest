/* Задача: Написать программу, которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. */

string[] smile = {":)", "welcome", ":3", "hello", ":D", "good day", ";)"};
int count = Counting(smile);
string[] newSmile = CreateNewArray(smile, count);
PrintArray(newSmile);

int Counting(string[] smile)
{
int count = 0;
 for (int i = 0; i < smile.Length; i++)
{
    if (smile[i].Length <= 3)
        count++;
}
return count;
}

string[] CreateNewArray(string[] array, int count)
{
    string[] array2 = new string[count];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;
        }
    }
    return array2;
}

void PrintArray(string[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");
}