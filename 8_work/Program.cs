//Task 1  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// int FindeNumber (int num)
// {
//     if (num > 0)
//     {
//         System.Console.Write(num + " " );
//         return FindeNumber(num-1);
//     }
//     return num;   
// }
// System.Console.WriteLine("Введитое число ");
// int num = Convert.ToInt32(Console.ReadLine());
// FindeNumber(num);

// Task 2 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int FindeNumberSum (int m, int n)
// {
//     if (m <= n )
//     {
//         return FindeNumberSum(m,n-1) + n; 
//     }
//     return 0;   
// }
// System.Console.WriteLine("Введитое число ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введитое число ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"M: {m}  N: {n}  ->   {FindeNumberSum(m,n)}");

// Task 3 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman (int m, int n)
{
    if (m == 0 ) return n + 1;
    if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m,n);
} 
System.Console.WriteLine("Введитое число ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введитое число ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"M: {m}  N: {n}  ->   {Akkerman(m,n)}");