/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();

int[,] matrixResult = GetMatrix(3, 4);

Console.WriteLine("Задан массив: ");

PrintMatrix(matrixResult);

double[] array = GiveMeAverageDouble(matrixResult);

Console.Write("Среднее арифметическое каждого столбца: ");

PrintArray(array);


int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + "; ");
        else Console.Write(array[i] + "]");
    }
}

double[] GiveMeAverageDouble(int[,] matrixRes)
{
    double[] matrix = new double[matrixRes.GetLength(1)];

    for (int i = 0; i < matrixRes.GetLength(1); i++)
    {
        for (int j = 0; j < matrixRes.GetLength(0); j++)
        {
            matrix[i] = matrix[i] + matrixRes[j,i];
        }
        Console.WriteLine();
        matrix[i] = Math.Round(matrix[i] / matrixRes.GetLength(0),2);
    }

    return matrix;
}