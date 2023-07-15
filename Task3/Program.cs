// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] myMarix = GetMatrix();
PrintMatrix(myMarix);
Console.WriteLine();
GetAverageForColumn(myMarix);

/* --/--/-- */

void GetAverageForColumn(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++) // Loop for columns (i)
    {
        double sum = 0;
        double result = 0;
        for (int j = 0; j < matrix.GetLength(0); j++) // Loop for rows (j)
        {
            sum += matrix[j, i];
        }
        result = Math.Round(
            sum / matrix.GetLength(0),
                3);

        Console.Write(result + "\t");
    }
}

int[,] GetMatrix()
{
    int[,] matrix = new int[3, 4];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 1000);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}