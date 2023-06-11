//task 1 Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("ВВедите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("ВВедите второе число");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a < b)
// {
//     Console.WriteLine($"максимальное число {b}");
// }
// else {
//     Console.WriteLine($"максимальное число {a}");
// }

//task 2 Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.WriteLine("ВВедите три числа число");
// int[] arr = new int[3];
// int count = 0;
// int max = 0;
// int i = 0;
// while (count < arr.Length) {
//     arr[count] = Convert.ToInt32(Console.ReadLine());
//     count++;
// }
// while (i < arr.Length ) {
//    if (max <= arr[i]) {
//     max = arr[i];
//    }
//     i++;
// }
// System.Console.WriteLine($"максимальное число -> {max}");

//task 3//  Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("ВВедите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 0)
// {
//     Console.WriteLine($"число {a} -> чётное");
// }
// else {
//     Console.WriteLine($"число {a} -> не чётное");
// }

// task 4 Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("ВВедите число");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= a)
{
    if (count % 2 == 0)
    {
        System.Console.Write($" {count}");
    }
    count++;
}
