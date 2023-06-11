//task 1
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

//task 2
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

//task 3// 
// Console.WriteLine("ВВедите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 0)
// {
//     Console.WriteLine($"число {a} -> чётное");
// }
// else {
//     Console.WriteLine($"число {a} -> не чётное");
// }

// task 4
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