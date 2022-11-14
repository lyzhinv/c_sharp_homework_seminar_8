// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int rows = 3;
int columns = 4;

int[,] baseArray = GetArray(rows, columns, 0, 10);

Console.WriteLine("Сгенерированный двумерный массив");
PrintArray(baseArray);
Console.WriteLine();

int[,] changesArray = SortRows(baseArray);

Console.WriteLine("Массив с упорядоченными по убыванию элементами каждой СТРОКИ");
Console.WriteLine();
PrintArray(changesArray);

int[,] SortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1, temp = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                };
            }
        }
    }
    return array;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
