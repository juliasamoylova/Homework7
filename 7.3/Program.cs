// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
int sum = 0;
int m = 0;
for (int n = 0; n < matrix.GetLength(1); n++)
{
    while (m < matrix.GetLength(0))
        sum = sum + matrix[m, n];
    Console.WriteLine(sum / matrix.GetLength(1));
    sum = 0;
    m++;
}

