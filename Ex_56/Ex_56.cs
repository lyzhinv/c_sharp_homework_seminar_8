// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int rows = 4;
int columns = 4;

int[,] baseArray = GetArray(rows, columns, 0, 10);
int[] baseArray2 = SumColumns(baseArray, rows, columns);

Console.WriteLine("Сгенерированный двумерный массив");
PrintArray(baseArray);
Console.WriteLine();

Console.WriteLine($"Cтрока с наименьшей суммой элементов - {FindMin(baseArray2)}");

Console.Write("Проверка сумм по строкам: ");
Console.Write(String.Join("; ", SumColumns(baseArray, rows, columns)) + ".");

int[] SumColumns(int[,] array, int m, int n) // метод для получения сумм по строкам
{
    int[] result = new int[m];

    for (int i = 0, sum = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sum += array[i, j];
        }
        result[i] = result[i] + sum;
        sum = 0;
    }
    return result;
}

int FindMin(int[] array) // метод для нахождения минимального значения сумм строк массива
{
    int min = 99999999;
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            min = array[i];
            count = i + 1;
        }
    }
    return count;
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

