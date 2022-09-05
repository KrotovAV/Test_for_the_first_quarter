//Задача: Наисать программу, которая из имеющегося массива строк формирует
// массив из строк, длинна котрых меньше либо равна 3символа. Первоначальный
// массивможноввести с клавиатуры, либо задать на старте выполнеия алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

//solution_1 - "... имеющегося массива строк ..."

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

string[] arrWords = {"as", "yyljh", "gh5", "gamm", "dhurnb34", "kValueTask", "s5", "Fl_", "gf" };

Console.WriteLine();
Console.Write("Source array - ");

PrintArray(arrWords);

string[] new3s = NewArrThreeSymbol(arrWords);
Console.Write("Final array - ");
PrintArray(new3s);
Console.WriteLine();