// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// Пример:
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] GenerateMatrix(int rows, int columns)
{   
    double[,] matrix = new double [rows,columns];
    var random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = random.Next(-9,99);
        }
    }
    return matrix;
}

void PrintMatrix (double[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            Console.Write($"{matrix[row,column]}\t");
        }
        Console.WriteLine("");
    }
}

int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());

PrintMatrix(GenerateMatrix(row,column));