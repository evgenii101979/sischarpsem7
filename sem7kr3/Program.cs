// Задача 53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.
//Изначальный массив: 1 4 7 25 9 2 38 4 2 4
//Итоговый массив: 8 4 2 45 9 2 31 4 7 2

// методы по развороту массива

int[,] ChangeRows(int[,] array)
{
    int[,] changeArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        int temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
    return changeArray;
}







FillArra(array);
int[,] FillArra(int[,] filladArra)
{

    for (int i = 0; i < filladArra.GetLength(0); i++)
    {
        for (int j = 0; j < filladArra.GetLength(1); j++)
        {
            if (i == 0)
            {
                (filladArra[i, j], filladArra[filladArra.GetLength(1) - 1, j]) 
                = (filladArra[filladArra.GetLength(1) - 1, j], filladArra[i, j]);
            }
        }
    }
    return filladArra;
}
Console.WriteLine();
PrintArray(array);