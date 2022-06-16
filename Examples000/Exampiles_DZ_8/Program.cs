// Задача №1 Задайте двумерный массив. Напишите программу, которая
//    упорядочит по убыванию элементы каждой строки двумерного массива.


// void Print(int[,] matr)
// {
//     int row_size = matr.GetLength(0);
//     int column_size = matr.GetLength(1);

//     for (int i = 0; i < row_size; i++)
//     {
//         for (int j = 0; j < column_size; j++)
//             Console.Write($" {matr[i, j],2} ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] MassNums(int row, int column, int from, int to)
// {
//     int[,] matr = new int[row, column];

//     for (int i = 0; i < row; i++)
//         for (int j = 0; j < column; j++)
//             matr[i, j] = new Random().Next(from, to);
//     return matr;
// }

// void OrderElMin(int[,] matr)
// {
//     int row_size = matr.GetLength(0);
//     int column_size = matr.GetLength(1);

//     for (int i = 0; i < row_size; i++)
//     {
//         for (int j = 0; j < column_size; j++)
//         {
//             for (int k = 0; k < column_size - 1; k++)
//                 if (matr[i, k] < matr[i, k + 1])
//                     (matr[i, k], matr[i, k + 1]) = (matr[i, k + 1], matr[i, k]);
//         }
//     }
// }
// Console.Write(" количество строк - ");
// int row = int.Parse(Console.ReadLine());

// Console.Write(" количество столбцов - ");
// int column = int.Parse(Console.ReadLine());

// int[,] matrix = MassNums(row, column, 0, 10);
// Print(matrix);

// OrderElMin(matrix);
// Print(matrix);

// Задача № 2. Задайте прямоугольный двумерный массив. Напишите программу,
//    которая будет находить строку с наименьшей суммой элементов.
// void Print(int[,] matr)
// {
//     int row_size = matr.GetLength(0);
//     int column_size = matr.GetLength(1);
//     for (int i = 0; i < row_size; i++)
//     {
//         for (int j = 0; j < column_size; j++)
//             Console.Write($" {matr[i, j],2} ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int[,] MassNums(int row, int column, int from, int to)
// {
//     int[,] matr = new int[row, column];
//     for (int i = 0; i < row; i++)
//         for (int j = 0; j < column; j++)
//             matr[i, j] = new Random().Next(from, to);
//     return matr;
// }
// void RowSmallAmount(int[,] matr)
// {
//     int row_size = matr.GetLength(0);
//     int column_size = matr.GetLength(1);
//     int amount = 100;
//     int num;
//     int smallest = 0;
//     for (int i = 0; i < row_size; i++)
//     {   
//         num = 0;
//         for (int j = 0; j < column_size; j++)
//             num += matr[i, j];
//             // Console.WriteLine(num);
//         if (amount > num)
//         {
//             amount = num;
//             smallest = i;
//         }
//     }
//     Console.Write($"Строка с наименьшей суммой на позицию - {smallest + 1}");
// }
// Console.Write("Количество строк - ");
// int row = int.Parse(Console.ReadLine());

// Console.Write("количество столбцов - ");
// int column = int.Parse(Console.ReadLine());

// int[,] matrix = MassNums(row, column, 0, 10);
// Print(matrix);

// RowSmallAmount(matrix);

// Задача №3. Задайте две матрицы. Напишите программу,
//    которая будет находить произведение двух матриц.
// void Print(int[,] matr)
// {
//     int row_size = matr.GetLength(0);
//     int column_size = matr.GetLength(1);
//     for (int i = 0; i < row_size; i++)
//     {
//         for (int j = 0; j < column_size; j++)
//             Console.Write($" {matr[i, j],2} ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int[,] MassNums(int row, int column, int from, int to)
// {
//     int[,] matr = new int[row, column];
//     for (int i = 0; i < row; i++)
//         for (int j = 0; j < column; j++)
//             matr[i, j] = new Random().Next(from, to);
//     return matr;
// }
// int[,] MatrixAddition(int[,] matr_first, int[,] matr_second)
// {
//     int row_size = matr_first.GetLength(0);
//     int column_size = matr_first.GetLength(1);
//     int[,] pr_matrix = new int[row_size, column_size];
//     for (int i = 0; i < row_size; i++)       
//         for (int j = 0; j < column_size; j++)
//             pr_matrix[i, j] = matr_first[i, j] * matr_second[i, j];            
//     return pr_matrix;
// }


// Console.Write("Количество строк - ");
// int row = int.Parse(Console.ReadLine());
// Console.Write("Количество столбцов - ");
// int column = int.Parse(Console.ReadLine());

// int[,] matr_1 = MassNums(row, column, 0, 10);
// Print(matr_1);
// int[,] matr_2 = MassNums(row, column, 0, 10);
// Print(matr_2);

// int[,] res_matrix = MatrixAddition(matr_1, matr_2);
// Print(res_matrix);

// 3. Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз 
//    встречается элемент входных данных. Значения элементов массива 0..9
void Print(int[,] matr)
{
    int row_size = matr.GetLength(0);
    int column_size = matr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {matr[i, j],2} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] matr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            matr[i, j] = new Random().Next(from, to);
    return matr;
}

int[] FrequencyDict(int[,] matr)
{
    int[] freq = new int[10];

    foreach (int item in matr) freq[item] += 1;
    return freq;
}

void PrintMass(int[] matr)
{
    for (int i = 0; i < matr.Length; i++)
        Console.WriteLine($"{i} встречается - {matr[i]}");
    Console.WriteLine();
}

Console.Write("Количество строк -");
int row = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов - ");
int column = int.Parse(Console.ReadLine());

int[,] matr_1 = MassNums(row, column, 0, 10);
Print(matr_1);

int[] mass = FrequencyDict(matr_1);
PrintMass(mass);