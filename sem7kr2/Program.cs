﻿// Задача 48: Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.

//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5




Console.Clear();
Console.WriteLine("Введите колличество строк двумерного массива ");
int rowCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов двумерного массива ");
int columnCount = int.Parse(Console.ReadLine());
int[,] array = FillArray(rowCount, columnCount);
PrintArray(array);

int[,] FillArray(int rows, int columns)
{
    int[,] filledArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = i + j;
        }

    }
    return filledArray;
}
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            System.Console.Write(" " + inputArray[i, j]);
        }
        System.Console.WriteLine();

    }
}