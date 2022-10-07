// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// Console.WriteLine("Enter row number: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter column number: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine();
// int[,] array = new int[m, n];
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(-100, 101);
//         }
//     }
// }
// FillArray(array);
// PrintArray(array);


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// int[,] array = new int[3, 4];
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 1000);
//         }
//     }
// }
// FillArray(array);
// PrintArray(array);
// Console.WriteLine("Enter row position: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter column position: ");
// int n = int.Parse(Console.ReadLine()!);
// if((m >= array.GetLength(0))||(n >= array.GetLength(1)))
// {
//     Console.WriteLine("No element on this postion");
// }
// else
// {
//     Console.WriteLine($"Element for this position = {array[m, n]}");
// }


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// int[,] array = new int[3, 4];
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// FillArray(array);
// PrintArray(array);
// double ColumnAverage(double x, double y, double z)
// {
//     double sum = x + y + z;
//     double average = sum / 3;
//     return average;
// }
// double Col1Average = ColumnAverage(array[0, 0], array[1, 0], array[2, 0]);
// double Col2Average = ColumnAverage(array[0, 1], array[1, 1], array[2, 1]);
// double Col3Average = ColumnAverage(array[0, 2], array[1, 2], array[2, 2]);
// double Col4Average = ColumnAverage(array[0, 3], array[1, 3], array[2, 3]);
// Console.Write("Average for each column: ");
// Console.Write("{0:f1}", Col1Average);
// Console.Write("; " + "{0:f1}", Col2Average);
// Console.Write("; " + "{0:f1}", Col3Average);
// Console.Write("; " + "{0:f1}", Col4Average);