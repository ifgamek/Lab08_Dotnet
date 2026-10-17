// // // // // // // //задание 1

// // // // // // // PrintHeader();



// // // // // // // static void PrintHeader()
// // // // // // // {
// // // // // // //     PrintLine();

// // // // // // //     Console.WriteLine("title");
// // // // // // //     static void PrintLine()
// // // // // // //     {
// // // // // // //         Console.WriteLine("^_^");

// // // // // // //     }

// // // // // // //     PrintLine();
// // // // // // // }

// // // // // // //задание 2.1

// // // // // // static int IntMax(int a, int b)
// // // // // // {
// // // // // //     if (a > b) { return a; }
// // // // // //     else { return b; }
// // // // // // }
// // // // // // Console.WriteLine(IntMax(10, 20));

// // // // // //задание 2.2
// // // // // static bool IsEven(int n)
// // // // // {
// // // // //     return n % 2 == 0;
// // // // // }
// // // // // Console.WriteLine(IsEven(4));
// // // // // Console.WriteLine(IsEven(7));
// // // // // Console.WriteLine(IsEven(0));


// // // // //задание 3
// // // // using System.Data.SqlTypes;
// // // // using System.Reflection.Metadata.Ecma335;
// // // // using System.Runtime.InteropServices;

// // // // static double Average(int[] arr)
// // // // {
// // // //     return (double)arr.Sum() / arr.Length;
// // // // }

// // // // static int CountCreater(int[] arr, int limit)
// // // // {
// // // //     int count = 0;
// // // //     for (int i = 0; i < arr.Length; i++)
// // // //     {

// // // //         if (arr[i] > limit) { count++; }
// // // //     }
// // // //     return count;
// // // // }
// // // // int[] arr = { 120, 45, 300, 80, 15, 210 };
// // // // Console.WriteLine(Average(arr));
// // // // Console.WriteLine(CountCreater(arr, 100));

// // // //задание 4
// // // static string ToFahrenheit(double celsius)
// // // {
// // //     return $"{celsius} градусов по целсию = {celsius * 9 / 5 + 32} градусов по фаренгейту";

// // // }
// // // Console.WriteLine(ToFahrenheit(32));
// // // Console.WriteLine(ToFahrenheit(212));
// // // Console.WriteLine(ToFahrenheit(98.6));



// // //задание 5
// // static long Factorial(int n)
// // {
// //     int fact = 1;
// //     for (int i = 1; i <= n; i++)
// //     {
// //         fact *= i;
// //     }
// //     return fact;
// // }

// // static bool IsPrime(int n)
// // {
// //     return n % n == 0;
// // }

// // Console.WriteLine("Простые числа от 2 до 50");
// // for (int i = 2; i <= 50; i++)
// // {
// //     Console.WriteLine($"число {i} - {IsPrime(i)}");
// // }

// // Console.WriteLine(Factorial(5));


// //задание 6

// static bool ReadPositive(string message)
// {
//     do
//     {
//         Console.WriteLine("введите число");
//         int a = Convert.ToInt32(Console.ReadLine());
//         if (a > 0)
//         {
//             return true;
//         }
//         Console.WriteLine(message);
//     }

//     while (true);
// }
// Console.WriteLine(ReadPositive("ошибка! введите положительно число"));

// итоговое задание
static void Calulator()
{
    static int Sum() { }

    static int IntMax() { }

    static int Factorial() { }

    static void Exit() { return; }

}
Console.WriteLine("1 - сумма двух числа");
Console.WriteLine("2 - большее из двух числе");
Console.WriteLine("3 - файториал");
Console.WriteLine("4 - выход");
if
int a = Convert.ToInt32(Console.ReadLine());
