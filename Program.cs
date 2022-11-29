// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int a = new Random ().Next (2,11);
// Console.WriteLine(a);
// int b = new Random ().Next (2,11);
// Console.WriteLine(b);
// int n = a;
// int power = b;
// Console.Write(Math.Pow(a, power));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int a = new Random ().Next (11,1000);
// Console.WriteLine(a);
// int sum = 0;
//     while(a != 0)
//     {
//      sum =+(a % 10);
//         a/=10;
//     }     
// Console.WriteLine(sum);


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

