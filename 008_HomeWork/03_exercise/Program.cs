// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

double[,] GenerateMatrix(int rows, int columns)
{   
    double[,] matrix = new double [rows,columns];
    var random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = random.Next(1,10);
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

double[,] calcMatrixProduct (double[,]arg1,double[,]arg2,int row, int column)
{
    double [,] Matrix1 = arg1;
    double [,] Matrix2 = arg2;
    double [,] ProdMatrix = new double [row, column];

    for (int i = 0; i < Matrix1.GetLength(0); i++)
    {
        
         for (int j = 0; j < Matrix2.GetLength(1); j++)
            {
                for (int n = 0; n < Matrix2.GetLength(0); n++)
                {
                    ProdMatrix[i,j] += Matrix1[i,n] * Matrix2[n,j]; 
                }
            }
    }
    return ProdMatrix;
}


Console.WriteLine("Введите размер матрицы:");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
double[,] firstMatrix = GenerateMatrix(row, column);
double[,] secondMatrix = GenerateMatrix(row,column);
double [,] resultMatrix = calcMatrixProduct(firstMatrix,secondMatrix,row,column);
PrintMatrix(firstMatrix);
Console.WriteLine("");
PrintMatrix(secondMatrix);
Console.WriteLine("");
PrintMatrix(resultMatrix);