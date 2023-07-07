// // Task 1 Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] CreateMatrix (int m, int n)
// {
//     double[,] Matrix = new double[m, n];
//     Random rand = new Random();
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Matrix[i, j] = Math.Round(rand.Next(-100, 101) + rand.NextDouble(), 2);
//         }
//     }
//     return Matrix;
// }

// void PrintMatrix (double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine(" ");
//     }
// }
// System.Console.WriteLine("Введите колличество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите колличество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"строк: {m}, столбцов: {n}");
// PrintMatrix(CreateMatrix(m, n));

//Task 2 Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateMatrix (int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     Random rand = new Random();
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = rand.Next(0, 101);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine(" ");
//     }
// }

// string SearchMatrixElement (int[,] matrix, int posI, int posJ)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if(i == posI)
//         { 
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if(j == posJ) return($"Значение позиции {posI},{posJ} -> {matrix[i,j]}");
//             }
//         }
//     } 
//     return ($"Значение позиции {posI},  {posJ} -> такого числа в массиве нет"); 
// }
// System.Console.WriteLine("Введите колличество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите колличество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите искомую строку: ");
// int posI = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите искомый столбец: ");
// int posJ = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = CreateMatrix(m,n);
// PrintMatrix(matrix);
// System.Console.WriteLine(SearchMatrixElement(matrix, posI, posJ));

//Task 3 Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] CreateMatrix (int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     Random rand = new Random();
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = rand.Next(0, 10);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine(" ");
//         if(i == matrix.GetLength(0)-1) System.Console.WriteLine("-------------------------------");

//     }
// }

// void SearshArifm(int[,] matrix)
// {
//     double[] summa = new double[matrix.GetLength(0)];
//    for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             summa[i]+=matrix[j,i];
           
//         }
//         System.Console.Write($"{Math.Round(Convert.ToDouble(summa[i]/matrix.GetLength(0)),2)}"+ "\t");
//     } 
// }
// System.Console.WriteLine("Введите колличество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите колличество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = CreateMatrix(m,n);
// PrintMatrix(matrix);
// SearshArifm(matrix);
