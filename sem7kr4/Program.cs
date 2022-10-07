// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Например, изначально массив
//выглядел вот так:     Новый массив будет выглядеть вот так:
//1 4 7 2               1 4 49 2
//5 9 2 3               5 9 2 4
//8 4 2 4               8 4 4 4






//метод

int[,] MakeSq(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                array[i, j] = Convert.ToInt32(Math.Pow(array[i, j], 2));
        }
    }
    return array;
}