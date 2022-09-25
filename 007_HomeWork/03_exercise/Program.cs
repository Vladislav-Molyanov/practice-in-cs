// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

Console.WriteLine("Введите размер матрицы:");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
double[,] matrix = GenerateMatrix(row, column);
PrintMatrix(matrix);

Console.WriteLine("");
for (int j = 0; j < column; j++)
    {   
        double sum = 0;
        for (int i = 0; i < row; i++)
            {
                sum += matrix[i,j];  
            } 
            Console.WriteLine($"Средне арефметическое {j+1} столбца: {sum/matrix.GetLength(0)}");

    }
