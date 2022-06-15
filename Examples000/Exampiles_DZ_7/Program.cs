// Задача №1 Задайте двумерный массив размером M x N, заполненный
//  случайными числами. 
// void PrintArray(double[,] arr)
// {
//     int size_one = arr.GetLength(0);
//     int size_two = arr.GetLength(1);
//     for (int i = 0; i < size_one; i++)
//     {
//         for (int j = 0; j < size_two; j++)
//             Console.Write($"{arr[i, j],5} ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();

// }
// double[,] MassNums(int row, int column, int from, int to)
// {
//     double[,] arr = new double[row, column];
//     Random n_new = new Random();
//     for (int i = 0; i < row; i++)
//         for (int j = 0; j < column; j++)
//             arr[i, j] = Math.Round(n_new.NextDouble() * -10, 2);
//     return arr;


// }
// double[,] arr_1 = MassNums(4, 4, -8, 8);
// PrintArray(arr_1);

// double[,] arr_2 = MassNums(6,6,-6,6);
// PrintArray(arr_2);


// Задача №2 Напишите программу, которая на вход принимает позиции элемента в двумерном масиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет. 
// void PrintArray(int[,] arr)
// {
//     int size_one = arr.GetLength(0);
//     int size_two = arr.GetLength(1);
//     for (int i = 0; i < size_one; i++)
//     {
//         for (int j = 0; j < size_two; j++)
//             Console.Write($"{arr[i, j],5} ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();

// }
// int[,] MassNums(int row, int column, int from, int to)
// {
//     int[,] arr = new int[row, column];

//     for (int i = 0; i < row; i++)
//         for (int j = 0; j < column; j++)
//             arr[i, j] = new Random().Next(from, to);
//     return arr;
// }
// string FindNums(int[,] arr, int f, int s)
// {
//     int size_one = arr.GetLength(0);
//     int size_two = arr.GetLength(1);
//     string text = "";
//     if (f > size_one || f <= 0 || s > size_two || s <= 0)
//         text = $"{f} {s} -> not in the array";
//     for (int i = 0; i < size_one; i++)
//         for (int j = 0; j < size_two; j++)
//             if (i + 1 == f && j + 1 == s)
//             {
//                 text = $"arr[{f}, {s}] == {arr[i, j]} - > is in the array";
//                 break;
//             }
//     return text;
// }
// Console.Write(" введите позицию по горизонтале:  ");
// int first = int.Parse(Console.ReadLine());

// Console.Write(" введите позицию по вертикале:  ");
// int second = int.Parse(Console.ReadLine());

// int[,] arr_1 = MassNums(3, 4, 1, 11);
// PrintArray(arr_1);

// Console.WriteLine(FindNums(arr_1, first, second));


//  Задача №3 Задайте двумерный массив из целых чисел. 
//  Найдите среднее фрифметической элементов в каждом стобце. 
void PrintArray(int[,] arr)
{
    int size_one = arr.GetLength(0);
    int size_two = arr.GetLength(1);
    for (int i = 0; i < size_one; i++)
    {
        for (int j = 0; j < size_two; j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();

}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}
void ArithmeticMean(int[,] arr)
{
    int size_one = arr.GetLength(0);
    int size_two = arr.GetLength(1);
    double res;
    for (int i = 0; i < size_two; i++)
    {
        res = 0;
        for (int j = 0; j < size_one; j++) res += arr[j, i];
        Console.WriteLine($"{Math.Round(res / size_one, 1)}; ");
    }

}
Console.Write(" введите позицию по горизонтале:  ");
int size_one = int.Parse(Console.ReadLine());

Console.Write(" введите позицию по вертикале:  ");
int size_two = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(size_one, size_one, 1, 6);
PrintArray(arr_1);

ArithmeticMean(arr_1);