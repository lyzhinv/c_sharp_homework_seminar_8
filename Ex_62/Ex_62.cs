// Отсортировать ничетные столбцы массива по возрастанию и вывести массив изначальный и массив отсортированными нечетными стобцами

int rows = 4;
int columns = 4;

int[,] baseArray = GetSpiralArray(rows, columns);

Console.WriteLine();
if (rows == columns) PrintArray(baseArray);
else Console.WriteLine("Ошибка. Массив не квадратный");


int[,] GetSpiralArray(int m, int n)
{

    int[,] array = new int[m, n];
    int temp = 1, i = 0, j = 0;
    if (m == n)                                            // проверка, если массив не квадратный
    {
        while (temp <= m * n)
        {
            array[i, j] = temp;
            temp++;
            if ((i <= j + 1) && (i + j < n - 1))
            {
                j++;
            }
            else if ((i < j) && (i + j >= m - 1))
            {
                i++;
            }
            else if ((i >= j) && (i + j > n - 1))
            {
                j--;
            }
            else
            {
                i--;
            }
        }
    }
    else array[i, j] = 0;
    return array;
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
