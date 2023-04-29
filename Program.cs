//  Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ") ;
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[m, n];

// Random random = new Random(); 

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = random.NextDouble() * 20 -10 ; 
//     }
// }

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(String.Format("{0  :0.0  }" , array[i, j]));
//     }
//     Console.WriteLine( );
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



// int[,] array =
//        {
//             { 1, 4, 7, 2 },
//             { 5, 9, 2, 3 },
//             { 8, 4, 2, 4 }
//         };

// Console.Write("Введите номер строки: ");
// int row = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер столбца: ");
// int column = Convert.ToInt32(Console.ReadLine());

// int element = GetElement(array, row, column);

// if (element == -1)
// {
//     Console.WriteLine("Такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"Значение элемента: {element}");
// }


// int GetElement(int[,] array, int row, int column)
// {
//     int rowCount = array.GetLength(0);
//     int columnCount = array.GetLength(1);

//     if (row < 0 || row >= rowCount || column < 0 || column >= columnCount)
//     {
//         return -1;
//     }

//     return array[row, column];
// }


// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] array =
//        {
//             { 1, 4, 7, 2 },
//             { 5, 9, 2, 3 },
//             { 8, 4, 2, 4 }
//         };

// int rowCount = array.GetLength(0);
// int columnCount = array.GetLength(1);

// for (int j = 0; j < columnCount; j++)
// {
//     int sum = 0;
//     for (int i = 0; i < rowCount; i++)
//     {
//         sum += array[i, j];
//     }
//       double srednee = (double)sum / rowCount;
//      Console.WriteLine("Среднее арифметическое элементов в столбце {0}: {1:F1}",j+1 ,  srednee);
// };