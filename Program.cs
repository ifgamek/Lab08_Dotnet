// // // // // // // // //задание 1

// // // // // // // // PrintHeader();



// // // // // // // // static void PrintHeader()
// // // // // // // // {
// // // // // // // //     PrintLine();

// // // // // // // //     Console.WriteLine("title");
// // // // // // // //     static void PrintLine()
// // // // // // // //     {
// // // // // // // //         Console.WriteLine("^_^");

// // // // // // // //     }

// // // // // // // //     PrintLine();
// // // // // // // // }

// // // // // // // //задание 2.1

using System.Diagnostics;

static int IntMax()
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > b) { return a; }
    else { return b; }
}

// Console.WriteLine(IntMax());


// // // // // // //задание 2.2
// // // // // // static bool IsEven(int n)
// // // // // // {
// // // // // //     return n % 2 == 0;
// // // // // // }
// // // // // // Console.WriteLine(IsEven(4));
// // // // // // Console.WriteLine(IsEven(7));
// // // // // // Console.WriteLine(IsEven(0));


// // // // // //задание 3
// // // // // using System.Data.SqlTypes;
// // // // // using System.Reflection.Metadata.Ecma335;
// // // // // using System.Runtime.InteropServices;

// // // // // static double Average(int[] arr)
// // // // // {
// // // // //     return (double)arr.Sum() / arr.Length;
// // // // // }

// // // // // static int CountCreater(int[] arr, int limit)
// // // // // {
// // // // //     int count = 0;
// // // // //     for (int i = 0; i < arr.Length; i++)
// // // // //     {

// // // // //         if (arr[i] > limit) { count++; }
// // // // //     }
// // // // //     return count;
// // // // // }
// // // // // int[] arr = { 120, 45, 300, 80, 15, 210 };
// // // // // Console.WriteLine(Average(arr));
// // // // // Console.WriteLine(CountCreater(arr, 100));

// // // // //задание 4
// // // // static string ToFahrenheit(double celsius)
// // // // {
// // // //     return $"{celsius} градусов по целсию = {celsius * 9 / 5 + 32} градусов по фаренгейту";

// // // // }
// // // // Console.WriteLine(ToFahrenheit(32));
// // // // Console.WriteLine(ToFahrenheit(212));
// // // // Console.WriteLine(ToFahrenheit(98.6));



//задание 5
static long Factorial()
{
    int n = Convert.ToInt32(Console.ReadLine());
    int fact = 1;
    for (int i = 1; i <= n; i++)
    {
        fact *= i;
    }
    return fact;
}

// static bool IsPrime(int n)
// {
//     return n % n == 0;
// }

// Console.WriteLine("Простые числа от 2 до 50");
// for (int i = 2; i <= 50; i++)
// {
//     Console.WriteLine($"число {i} - {IsPrime(i)}");
// }

// Console.WriteLine(Factorial());


//задание 6

static int ReadPositive()
{

    while (true)
    {
        Console.Write("Введите пункт меню (0-3): ");
        try
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 0 && a <= 3)
                return a;
        }
        catch { }
        Console.WriteLine("Некорректный ввод, попробуйте снова.");
    }
}

// Console.WriteLine(ReadPositive());

// итоговое задание

int Sum(int a, int b) => a + b;

Console.WriteLine("1 - сумма двух чисел");
Console.WriteLine("2 - большее из двух числе");
Console.WriteLine("3 - файториал");
Console.WriteLine("0 - выход");

int a = ReadPositive();

switch (a)
{
    case 1:
        Console.WriteLine(Sum(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
        break;

    case 2:
        Console.WriteLine(IntMax());
        break;

    case 3:
        Console.WriteLine(Factorial());
        break;

}
