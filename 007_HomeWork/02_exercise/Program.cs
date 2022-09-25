// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

double[,] GenerateMatrix4x4()
{   

    int rows = 4;
    int columns = 4;
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

void ChecIndexMatrix ( int row, int column, double[,]matrix)
{
    if (matrix.GetLength(0) > row && matrix.GetLength(1) > column)
    {
        Console.WriteLine($"{matrix[row,column]}");
    }
    else
    {
        Console.WriteLine("Такого числа нет в массиве");
    }
}
Console.WriteLine("Введите позиции элемента в двумерном массиве");
int rows = (int)(Console.Read()-'0');
    rows--;
int columns = (int)(Console.Read()-'0');
    columns--;
double[,]matrix = GenerateMatrix4x4();
PrintMatrix(matrix);
ChecIndexMatrix(rows,columns,matrix);