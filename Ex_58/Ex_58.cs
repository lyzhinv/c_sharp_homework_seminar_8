// Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.

int rows = 2;
int columns = 2;
int[,] matrix1 = GetArray(rows, columns, 0, 10);
int[,] matrix2 = GetArray(rows, columns, 0, 10);

Console.WriteLine("Первая (левая) матрица");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Вторая (правая) матрица");
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица");
int[,] matrix3 = MultiplicationMatrix(matrix1, matrix2, rows, columns);
PrintArray(matrix3);


int[,] MultiplicationMatrix (int[,] array1, int[,] array2, int m, int n) // Метод, находящий произведение двух матриц
{
    int[,] resultarray = new int[m, n];
    for(int i = 0; i < resultarray.GetLength(0); i++)
    {
        for(int j = 0; j < resultarray.GetLength(1); j++)
        {
            int sum = 0;
            for(int k = 0; k < array1.GetLength(1); k++)
            {
                sum = sum + array1[i, k] * array2[k, j];
            }
            resultarray[i, j] = sum;
        }
    }
    return resultarray;
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