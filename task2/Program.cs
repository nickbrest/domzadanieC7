// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] CreateMatrix(int length, int width, int minimum, int maximum)
{
    int[,] matrix = new int[length, width];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(minimum, maximum);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write("{0,4:d}", matrix[i, j]);
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(5, 7, 0, 20);
PrintMatrix(matrix);
Console.WriteLine();

double summ = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        summ += matrix[j, i];
    }
    Console.WriteLine($"Среднее арефметическое столбца {i + 1} равно {summ / matrix.GetLength(0)}");
    summ = 0;
}