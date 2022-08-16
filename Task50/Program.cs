/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1, 7 -> такого числа в массиве нет */

Console.Clear();

int[,] matrixResult = GetMatrix(3, 4);

Console.WriteLine("Задан массив: ");

PrintMatrix(matrixResult);

Console.WriteLine("Введите номер строки");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца");
int column = Convert.ToInt32(Console.ReadLine());

int result = GiveMeMatrixElement(matrixResult, row, column);
if (result == -1)
{
    Console.WriteLine($"{row}, {column}  -> такого числа в массиве нет");
}
else Console.WriteLine($"{row}, {column}  -> {result}");

int GiveMeMatrixElement(int[,] array, int r, int col)
{
    if (r <= 0 || r >= array.GetLength(0) + 1 || col <= 0 || col >= array.GetLength(1) + 1) return -1;
    else return array[r - 1, col - 1];
}

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