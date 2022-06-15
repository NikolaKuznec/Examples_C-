//  Задача  Задайте двумерный массив размером M N,
//  заполненный случайными числами. 
// void Print(int[,] arr)
// {
//     int row_size = arr.GetLength(0);
//     int column_size = arr.GetLength(1);

//     for (int i = 0; i < row_size; i++)
//     {
//         for (int j = 0; j < column_size; j++)
//         {
//             Console.Write($" {arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int[,] MassNums(int row, int column, int from, int to)
// {
//     int[,] arr = new int[row, column];

//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             arr[i, j] = new Random().Next(from, to);
//         }
//     }
//     return arr;
// }
// Console.Write($"введите число 1 from ");
// int from = int.Parse(Console.ReadLine());

// Console.Write($"введите число 2 to ");
// int to = int.Parse(Console.ReadLine());

// Console.Write($"введите количество строк row ");
// int row = int.Parse(Console.ReadLine());

// Console.Write($"введите количество столбцов column ");
// int column = int.Parse(Console.ReadLine());

// Print(MassNums(row, column, from, to));



// Задача: Задайте двумерный массив размера M на N, каждый 
// элемент в массиве находится по формкле : A[][] = M + N.
// Веведете полученный массив на экран.
// void PrintArray (int[,] arr)
// {
//     int row_size = arr.GetLength(0);
//     int column_size = arr.GetLength(1);

//     for (int i = 0; i < row_size; i++)
//     {
//         for (int j = 0; j < column_size; j++)
//         {
//             Console.Write($" {arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void FillArray (int [,]matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = i+j;
//         }
//     }

// }
// int [,] matrix = new int [3,4];
// FillArray(matrix);
// PrintArray(matrix);


// Задача Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позицию по горизонтали и вертикали,
//  или напишите, что такого элемента нет. 
int[,] CopyArray(int[,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    int[,] result = new int[row_size, column_size];

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            result[i, j] = array[i, j];
        }
    }
    return result;
}
int[,] MassNums(int row_size, int column_size, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return result;
    
}
void PrintArray(int[,] arr)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] EvenPosition(int[,] array)
{
    int Length = array.GetLength(1);
    int width = array.GetLength(0);
    for (int i = 1; i < Length; i+2)
    {
        for (int j = 1; j < Length; j+2)
            array[i, j] = array[i, j] * array[i, j];
    }
    return array;
}



int[,] array = CopyArray(4,6,0,10);
Print(array);
Print(EvenPosition(array));