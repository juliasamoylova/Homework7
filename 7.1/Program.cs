// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задайте количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
decimal [,] matrix = new decimal [m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = Convert.ToDecimal(new Random().Next(-100,100))/10;
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}