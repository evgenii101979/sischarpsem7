// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12

//метод


int SumDiag(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
                sum = sum + array[i, j];
        }
    }
    return sum;
}