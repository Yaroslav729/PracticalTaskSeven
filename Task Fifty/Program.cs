// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();

Console.Write("Введите позицию элемента массива X: ");
int y = int.Parse(Console.ReadLine()!) - 1;
Console.Write("Введите позицию элемента массива Y: ");
int x = int.Parse(Console.ReadLine()!) - 1;
int[,] matrix = new int[5, 5];
void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++ )
    {
for (int j = 0; j < matrix.GetLength(1); j++)
{
    matrix[i, j] = new Random().Next(0, 30);}
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

    if (x < matrix.GetLength(0) && y < matrix.GetLength(1))
    {
        Console.WriteLine($"{matrix[x, y]}");
    } else {
        Console.WriteLine("Такого элемента нет");
}
}

InputMatrix(matrix);
PrintMatrix(matrix);
