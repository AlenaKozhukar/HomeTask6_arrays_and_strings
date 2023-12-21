// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.


char[,] symbols = new char[,] {{'s','y','m'},{'b','o','l'}};



string GetStringFrom2DArrayChar(char[,] symbols) // Метод для создания строки из двумерного массива символов
{
    string str = "";
    for (int i = 0; i < symbols.GetLength(0); i++)
    {
        for (int j = 0; j < symbols.GetLength(1); j++)
        {
            str += symbols[i,j];
        }
    }
    return str;
}

void PrintArray()
{
    for (int i = 0; i < symbols.GetLength(0); i++)
    {
        for (int j = 0; j < symbols.GetLength(1); j++)
        {
            System.Console.Write(symbols[i,j] +" ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

PrintArray();
string result = GetStringFrom2DArrayChar(symbols);
Console.WriteLine(result); 