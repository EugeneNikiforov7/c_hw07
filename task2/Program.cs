// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

string ValidateString(string coord)
{
    if (coord != string.Empty)
        return coord;
    else
        return "такого числа в массиве нет";
}

string FindCoordinates(int num, int[,] arr)
{
    string coord = string.Empty;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i ,j] == num) 
                coord = coord + " (" + i + "," + j + ")";
        }
    }    
    return coord;
}

void PrintIntArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {    
        for (int j = 0; j < arr.GetLength(1); j++)
            {
            Console.Write($"{arr[i , j]} ");
            }
    Console.WriteLine();
    }
}

int[,] CreateIntArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i,j] = new Random().Next(10, 100);
    return array;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] array = CreateIntArray(10, 10);
int number = GetInfo("Введите число от 10 до 99 для поиска его координат в массиве: ");
PrintIntArray(array);
string coordinatesNumber = ValidateString(FindCoordinates(number, array)); 
Console.WriteLine();
Console.Write($"{number} ->{coordinatesNumber}");
