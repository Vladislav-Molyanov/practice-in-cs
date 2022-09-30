// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine("");
    }
}


double[,] MatrixFlip(double[,] arg)
{
    double[,] matrix = arg;
    for (int i = 0; i < matrix.GetLength(0) ; i++)
    {
        bool swapped = true;
        while (swapped)
        {
            swapped = false;
            for (int j = 0; j < matrix.GetLength(1)-1; j++)
            {
                if (matrix[i,j] < matrix[i,j +1])
                {
                    double temp = matrix[i,j];
                    matrix[i,j] = matrix[i,j+1];
                    matrix[i,j+1] = temp;
                    swapped = true;

                }
            }
        }
    }
    return matrix;
}

Console.WriteLine("Введите размер матрицы:");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
double[,] matrix = GenerateMatrix(row, column);
PrintMatrix(matrix);
double [,] newMatrix = MatrixFlip(matrix);
Console.WriteLine("Отсортированный массив");
PrintMatrix(newMatrix);