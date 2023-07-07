// //Task 1 Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
//     }
// }

// int[,] SortMatrix(int[,] matrix)
// {
//     int temp = 0;
//      for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         temp = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int l = 0; l < matrix.GetLength(1)-1; l++)
//             {
//                 if(matrix[i,l] < matrix[i,l+1])
//                 {
//                     temp = matrix [i,l];
//                     matrix [i,l] = matrix[i,l+1];
//                     matrix [i,l+1] = temp;
//                 }
//             }
//         }
        
//     }
//     return matrix;
// }
// System.Console.WriteLine("Введите колличество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите колличество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = CreateMatrix(m,n);
// PrintMatrix(matrix);
// System.Console.WriteLine("В итоге получается такой массив: ");
// matrix = SortMatrix(matrix);
// PrintMatrix(matrix);

// Task 2 Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
//     }
// }
// int SearchMinSumm(int[,] matrix)
// {
//     int summa = 0;
//     int summaMin = 0;
//     int tempI = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             summa+=matrix[i, j];
//           if(summa>summaMin)
//           {
//             summaMin = summa;
//             tempI= i;
//           }
//         }
//         summa = 0;
//     } 
//     return tempI+1;
// }

// System.Console.WriteLine("Введите колличество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите колличество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = CreateMatrix(m,n);
// PrintMatrix(matrix);
// System.Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {SearchMinSumm(matrix)} строка");


// Task 3 Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
//     }
// }

// int[,] MatrixMultiplication (int[,] matrixA, int[,] matrixB)
// {
//     int[,] matrixC = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
//     for (int i = 0;i < matrixA.GetLength(0);i++)
//     {
//         for(int j = 0;j< matrixA.GetLength(1);j++)
//         {
//             matrixC[i, j] = 0;

//             for (var k = 0; k < matrixA.GetLength(1); k++)
//             {
//                 matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
//             }
//         }
//     }
//     return matrixC;
// }
// System.Console.WriteLine("Введите колличество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите колличество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrixA = CreateMatrix(m, n);            
// Console.WriteLine("Матрица A:");
// PrintMatrix(matrixA);
// int[,] matrixB = CreateMatrix(m, n);     
// Console.WriteLine("Матрица B:");
// PrintMatrix(matrixB);
// int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
// Console.WriteLine("Произведение матриц:");
// PrintMatrix(matrixC);

//Task 4 .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

// int[,,] CreateMatrix (int m, int n, int z)
// {
//     int[,,] matrix = new int[m, n, z];
//     Random rand = new Random();
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             for (int k = 0; k <z; k++)
//             {
//                  matrix[i, j, k] = rand.Next(10, 100);
//             }
           
//         }
//     }
//     return matrix;
// }
// void PrintMatrix (int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 System.Console.Write(matrix[i, j, k] + $"({i}, {j}, {k})" + "\t");
//             }
//             System.Console.WriteLine(" ");
//         }
//     }
// }
// System.Console.WriteLine("Введите колличество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите колличество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите глубину : ");
// int z = Convert.ToInt32(Console.ReadLine());
// int[,,] matrix = CreateMatrix(m, n, z);
// PrintMatrix(matrix);

