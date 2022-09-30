// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

Console.WriteLine("Введите размер матрицы:");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
double[,] matrix = GenerateMatrix(row, column);
PrintMatrix(matrix);

void minRow (double[,] arg)
{
    double minRow = -1;
    double sum = 0;
    double minSum = double.MaxValue;

    for (int i = 0; i < arg.GetLength(0); i++)
    {   
        sum = 0;
        for (int j = 0; j < arg.GetLength(1); j++)
        {   
                sum += matrix[i,j];
        } 
        

        if (sum < minSum)
        {
            minRow = i+1;
            minSum = sum;
        }

    }
        Console.WriteLine($"{minRow}  строка");
}
minRow(matrix);