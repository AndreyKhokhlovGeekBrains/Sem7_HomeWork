// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите кол-во строк: ");
string? valueForRows = Console.ReadLine();

int rows = CheckForNumber(valueForRows, "Введите кол-во строк: ");

Console.WriteLine("Введите кол-во столбцов: ");
string? valueForColumns = Console.ReadLine();

int columns = CheckForNumber(valueForColumns, "Введите кол-во столбцов: ");

double[,] array2D = new double[rows, columns];
FillMatrix(array2D);
PrintMatrix(array2D);

/* --/--/-- */

int CheckForNumber(string value, string prompt)
{
    if (int.TryParse(value, out int number) && number > 0) return number;
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        Console.WriteLine(prompt);
        string? newValue = Console.ReadLine();
        return CheckForNumber(newValue, prompt);
    }
}

void FillMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int[] values = new int[2] { -1, 1 }; // Значения для того, чтобы чередовать знак натурального числа
            matrix[i, j] = Math.Round(
                new Random().NextDouble() *
                    Math.Pow(10, new Random().Next(0, 3)) *
                         values[new Random().Next(values.Length)],
                    3);
        }
    }
}

void PrintMatrix(double[,] matrix)
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
