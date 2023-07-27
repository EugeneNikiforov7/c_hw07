// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] GetAverage(int[,] arr)
{
    double[] avrg = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            avrg[i] = avrg[i] + arr[j, i];
        }
    avrg[i] = avrg[i]/arr.GetLength(0);
    }
    return avrg;
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

int number = GetInfo("Введите размерность массива: ");
int[,] array = CreateIntArray(number, number+2);
PrintIntArray(array);
double[] average = GetAverage(array);
Console.Write($"Среднее арифметическое каждого столбца: " + String.Join("; ", average));