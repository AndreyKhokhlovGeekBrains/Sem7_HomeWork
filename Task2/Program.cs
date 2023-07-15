// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] matrix = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

Console.WriteLine("Введите позицию для элемента в строках: ");
string? valueForRows = Console.ReadLine();

int row = CheckForNumber(valueForRows, "Введите позицию для элемента в строках: ");

Console.WriteLine("Введите позицию для элемента в столбцах: ");
string? valueForColumns = Console.ReadLine();

int column = CheckForNumber(valueForColumns, "Введите позицию для элемента в столбцах: ");

PrintMatrix(matrix);
Console.WriteLine(
    GetMatrixValue(matrix, row, column)
);

/* --/--/-- */

string GetMatrixValue(int[,] martix, int rowIndex, int columnIndex)
{
    string prompt = "Такого элемента нет";
    
    if (rowIndex < martix.GetLength(0) && columnIndex < matrix.GetLength(1))
    {
        int value = matrix[rowIndex - 1, columnIndex - 1];
        return prompt = $"Значение элемента: {value}";
    }
    else
    {
        return prompt;
    }
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