//Task 1 Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// System.Console.WriteLine("Введите 3-x значное число");
// int a = Convert.ToInt32(System.Console.ReadLine());
// if (a > 99 && a < 1000){
//     int b =  (a % 100) / 10;
//     System.Console.WriteLine($"вторая цифра числа {a} -> {b}");
// }
// else
// {Console.WriteLine("вы ввели неверное число");}    

//task 2 Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// bool Valid ( int num ) 
// {
//     if (num < 99 )
//     {
//     System.Console.WriteLine("вы ввели число меньше трёхзначного значения");
//     return false;
//     }
//     return true;
    
// }
// int Find(int num)
// {
//     while (num / 1000 != 0)
//     {
//         num /= 10;
//     }
//     return num % 10;
// }

// System.Console.WriteLine("Введите число");
// int a = Convert.ToInt32(System.Console.ReadLine());
// if (Valid(a))
// {
//     System.Console.WriteLine(Find(a));
// }


// task 3 Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Test (int num)
{
    if (num == 6 || num == 7)
    {
        return true;
    }
     return false;
}
System.Console.WriteLine(" Введите число обозначающее день недели");
int a = Convert.ToInt32(Console.ReadLine());
if(a < 8 )
{
    if (Test(a))
    {
        System.Console.WriteLine($"День {a} -> выходной");
    }
    else
    {
        System.Console.WriteLine($"День {a} -> не выходной");
    }
}
else
{
    System.Console.WriteLine("ввели неправильное значение");
}