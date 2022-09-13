// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}


int MinSummString(int[,] matrix)
{
    int summ = 0;
    int summMin = 0;
    int summMinRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                summ += matrix[i, j];
                summMin = summ;
            }
            else
            {
                summ += matrix[i, j];
            }
        }
        if (summ < summMin)
        {
            summMinRow = i;
            summMin = summ;
        }
        summ = 0;
    }
    return summMinRow;
}

int[,] matrix = CreateMatrix(5, 7, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
int numberRow = MinSummString(matrix);
Console.WriteLine($"Строка с минимальной суммой элементов {numberRow + 1}");