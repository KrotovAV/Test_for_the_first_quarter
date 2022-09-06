//Задача: Наисать программу, которая из имеющегося массива строк формирует
// массив из строк, длинна котрых меньше либо равна 3символа. Первоначальный
// массив можно ввести с клавиатуры, либо задать на старте выполнеия алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

//solution_4 - "Первоначальный массив можно ввести с клавиатуры, указав количество 
//элемнтов массива и потом каждый элемент".


string[] WriteReadLine(int n, string[] arr3)
{
    for (int i = 0; i < n; i++)
    {
    Console.WriteLine("Write array element");
    arr3[i] = (Console.ReadLine());
    }
    return arr3;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]}, ");
        //Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
}

string[] NewArrThreeSymbol(string[] arr2)
{
    int n = 1;
    string[] newArr = new string[n];
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i].Length <= 3) 
        {
            Array.Resize(ref newArr, n+1);
            newArr[n-1] = arr2[i];
//            Console.WriteLine($" {i} - {n-1}");
            n++;
        }
    }
    Array.Resize(ref newArr, n-1);
    return newArr;
}

Console.WriteLine();
Console.WriteLine("Write array size");
int n = int.Parse(Console.ReadLine());

string[] arr = new string[n];

WriteReadLine(n, arr);

Console.WriteLine();
Console.Write("Source array - ");

PrintArray(arr);

string[] new3s = NewArrThreeSymbol(arr);
Console.Write("Final array - ");
PrintArray(new3s);



