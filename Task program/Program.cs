// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] array1 = new string[7] {"hello", "world", "you", "good", "and", "love","me"};
string[] array2 = new string[array1.Length];

void SecondArrayWithThreeSymbol(string[] array1, string[] array2)
{
    int count=0;
    for (int i = 0; i < array1.Length; i++)   
    {
        if (array1[i].Length <= 3)
        {
            array2[count]=array1[i];
            count++;
        }   
    }
}

void PrintArray(string[] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($" {array1[i]}",3);
    }
    Console.Write("]");
} 

void PrintArray1(string[] array2)
{
    Console.Write("[");
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($" {array2[i]}");
    }
    Console.Write("]");
}

PrintArray(array1);
SecondArrayWithThreeSymbol(array1,array2);
Console.WriteLine();
PrintArray1(array2);
