//Task 1 Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// int[] CreateArray (int size)
// {
//     int[] array = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rand.Next(100, 1001);
//     }
//     return array;
// }
// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine(" ");
// }

// int SearchEven(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count++;
//     }
//     return count;
// }

// System.Console.WriteLine($" Введите длинну массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// PrintArray(array);
// System.Console.WriteLine($" Колличество чётных элементов в массиве -> {SearchEven(array)}");

// Task 2 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateArray (int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rand.Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine(" ");
// }

// int SearchSumm(int[] array)
// {
//     int summa = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0) summa += array[i];
//     }
//     return summa;
// }
// System.Console.WriteLine($" Введите длинну массива");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($" Минимально значение");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($" Максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size, minValue, maxValue);
// PrintArray(array);
// System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях -> {SearchSumm(array)}");

// Task 3 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray (int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * 100, 2);
    }
    return array;
}

void PrintArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine(" ");
}

double SearchMaxMin (double[] array)
{
    double minElement = array[0];
    double maxElemnt = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < minElement) minElement = array[i];
        if(array[i] > maxElemnt) maxElemnt = array[i];
    }
    return Math.Round(Convert.ToDouble(maxElemnt - minElement), 2);
}

System.Console.WriteLine($" Введите длинну массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(size);
PrintArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальными занчениями -> {SearchMaxMin(array)}");



