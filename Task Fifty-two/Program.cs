// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();

int[,] matrix = new int[5, 5];

void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++ )
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
{
    matrix[i, j] = new Random().Next(0, 10);}
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine();
    }
}

void AverageSum(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sum += matrix[i, j];
        }
        Console.Write($"{sum / matrix.GetLength(0)}\t ");
        
    }
}

InputMatrix(matrix);
PrintMatrix(matrix);
AverageSum(matrix);
