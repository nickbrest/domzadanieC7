// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

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


void ChangeMatrix(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (j + i == matrix.GetLength(0)) break;
            temp = matrix[i, j + i];
            matrix[i, j + i] = matrix[j + i, i];
            matrix[j + i, i] = temp;
        }
}

int[,] matrix = CreateMatrix(7, 7, 0, 10);
if (matrix.GetLength(0) != matrix.GetLength(1))
    Console.WriteLine("Замена невозможна");
else
{
    PrintMatrix(matrix);
    Console.WriteLine();
    ChangeMatrix(matrix);
    PrintMatrix(matrix);
}