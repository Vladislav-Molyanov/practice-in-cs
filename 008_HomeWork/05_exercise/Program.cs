// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


double[,] FillSpiralMatrix (int size)
{
    double[,] matrix = new double[size,size];
    int Num = 1;
    int direction;
    int i;
    int j;
    do
    {
        matrix[i,j++] = Num;
        Num++;
        if(Num == size )
        {
            matrix[i++,j];
            if (true)
            {
                
            }
        }
    } while (size <= size*size);

    
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

Console.WriteLine("Введите длину квадрата");
int n = int.Parse(Console.ReadLine());
double[,] spiralMatrix = FillSpiralMatrix(n);

PrintMatrix(spiralMatrix);