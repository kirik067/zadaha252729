// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int a = new Random ().Next (2,11);
// Console.WriteLine(a);
// int b = new Random ().Next (2,11);
// Console.WriteLine(b);
// int sum = Number(a, b);
// Console.WriteLine("number is " + sum);
// int Number (int a, int b)
// {
//     int result = 1;
//     for(int i=1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     return result;

// }



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int a = new Random ().Next (11,1000);
// Console.WriteLine(a);
// int len = NumberLen(a);
// SumNumbers(a, len);
// int NumberLen(int a)
// {
//     int i = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         i++;
//     }
//     return i;
// }
// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int[8];
// PrintArray(array);
// Console.WriteLine();
// var arr = FillArray(8);
// PrintArray(arr);

// int[] FillArray(int length)
// {
//     int[] result = new int[length];
//     for(int i =0; i < result.Length; i++)
//     {
//         result[i] = new Random().Next(0, 50);
//     }
//     return result;
// }

// void PrintArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
// }

