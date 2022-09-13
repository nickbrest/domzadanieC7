// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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


int[,] matrix = CreateMatrix(5, 5, 0, 20);
PrintMatrix(matrix);
Console.WriteLine();
Console.Write($"Введите искомое число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int count = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == number)
        {
            count++;
            Console.WriteLine($"{count} позиция заданного числа: сторка {i + 1}, столбец {j + 1}");
        }
    }
if (count == 0)
    Console.WriteLine($"Заданное число в матрице отсутствует");