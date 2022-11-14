// Отсортировать ничетные столбцы массива по возрастанию и вывести массив изначальный и массив отсортированными нечетными стобцами

int rows = 3;
int columns = 4;

int[,] baseArray = GetArray(rows, columns, 0, 10);

Console.WriteLine();
PrintArray(baseArray);

int[,] changesArray = SortColumns(baseArray);

Console.WriteLine();
PrintArray(changesArray);

int[,] SortColumns(int[,] array)
{
    for (int i = 1; i < array.GetLength(1); i+=2)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = j + 1, temp = 0; k < array.GetLength (0); k++)
            {
                if (array[j, i] < array[k, i])
                {
                    temp = array[k, i];
                    array[k, i] = array[j, i];
                    array[j, i] = temp;
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
