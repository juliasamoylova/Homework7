// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] matrix = new int[4, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-100, 100);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Задайте номер строки, в которой находится элемент: ");
int RowNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте номер столбца, в котором находится элемент: ");
int ColumnNumber = Convert.ToInt32(Console.ReadLine());
if (RowNumber >= 0 && RowNumber <= matrix.GetLength(0) && ColumnNumber >= 0 && ColumnNumber <= matrix.GetLength(1))
{
    Console.WriteLine($"Запрошенный элемент равен {matrix[RowNumber-1, ColumnNumber-1]}");
}
else Console.WriteLine("Запрошенного элемента не существует");
