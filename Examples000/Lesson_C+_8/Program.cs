// Задача №1 Задайте двухмерный массив. Напишите программу которая поменяет местам
//  первую и последнюю строку. 
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// void ChangeRows(int[,] matr)
// {
//     int lr = matr.GetLength(0) - 1;
//     int fr = 0;
//     for (int i = 0; i < matr.GetLength(1); i++)
//     {
//         (matr[fr, i], matr[lr, i]) = (matr[lr, i], matr[fr, i]);
//     }
// }
// int[,] matrix = new int[5, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// ChangeRows(matrix);
// PrintArray(matrix);

// Задача№2 Задайте двумерный массив. напишите программу,
//  которая заменяет строки на столбцы. В случае, если это невозможно, 
//  программа должна вывести сообщение для пользователя. 
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// void TranspArray(int[,] matr)
// {
//     int row = matr.GetLength(0);
//     int column = matr.GetLength(1);
//     if (row != column)
//     {
//     Console.WriteLine("Это не возможно! ");
//     }
//     else 
//     {
//       for (int i = 0; i < row; i++)
//         {
//          for (int j = 0; j < i; j++)
//            {
//             (matr[i, j], matr[j, i]) = (matr[j, i], matr[i, j]);
//            }
//         }
//     }
// }  
// int[,] matrix = new int[5, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// TranspArray(matrix);
// PrintArray(matrix);




