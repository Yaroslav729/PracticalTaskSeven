// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.

Console.Clear();

Console.Write("Введите размер массива: ");
int[]size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
void InputMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++ )
    {
for (int j = 0; j < matrix.GetLength(1); j++)
{
    matrix[i, j] = new Random().Next(-30, 30) / 10.0;}
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine();
    }
}
InputMatrix(matrix);
PrintMatrix(matrix);