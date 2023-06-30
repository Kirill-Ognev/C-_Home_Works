// Task 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// void FindPolindrom(int num)
// {
//     int one = 0;
//     int two = 0;
//     int four = 0;
//     int five = 0;
//     int numm = num;
//     for (int i = 0; i < 5; i++)
//     {
//         if(i == 0)
//         {
//             five = num % 10;
//             num /= 10;
//         }
//         if(i == 1)
//         {
//             four = num % 10;
//             num /= 10;
//         }
//         if(i == 2)
//         {
//             num /= 10;
//         }
//         if(i == 3)
//         {
//             two = num % 10;
//             num /= 10;
//         }
//         if(i == 4)
//         {
//             one = num % 10; 
//         }
//     }
//     if (one == five && two == four)
//     {
//         System.Console.WriteLine($"{numm} -> да");
//     }
//     else
//     {
//         System.Console.WriteLine($"{numm} -> нет");
//     }
    
    
// }

// System.Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 9999 && num < 100000)
// {
//     FindPolindrom(num);
// }
// else
// {
//     System.Console.WriteLine("Ввели невероное значение");   
// }

// task 2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double FindLong(int Xa, int Ya, int Za, int Xb, int Yb, int Zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(Xa-Xb, 2) + Math.Pow(Ya-Yb, 2)+ Math.Pow(Za-Zb, 2)),2);
// } 
// System.Console.WriteLine("Введите Коардинату X  первой тчоки: ");
// int Xa = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите Коардинату Y  первой тчоки: ");
// int Ya = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите Коардинату Z  первой тчоки: ");
// int Za = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите Коардинату X  второй тчоки: ");
// int Xb = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите Коардинату Y  второй тчоки: ");
// int Yb = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите Коардинату Z  второй тчоки: ");
// int Zb = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Растояние между точками -> {FindLong(Xa, Ya, Za, Xb, Yb, Zb)} ");

//Task 3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void PrintNum(int num)
// {
//     for (int i = 1; i <= num; i++)
//     {
//         Console.WriteLine($"{i} -> {Math.Pow(i,3)}");
//     }
// }
// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// PrintNum(num);