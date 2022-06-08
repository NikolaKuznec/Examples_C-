//Задача №1) Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// int CountNum()
// {
//     int count = 0;
//     string number;
//     while (true)
//     {
//         Console.Write("enter number : ");
//         number = Console.ReadLine();
//         if (number == "") return count;
//         else if (int.Parse(number) > 0) count +=1;
//     }
// }
// Console.WriteLine(CountNum());


// Задача № 2) Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// void Summ (double b1, double k1, double b2, double k2)
// {
//     double x = (b1 - b2) / (k1 - k2);
//     double y = k1 * x + b1;
//     Console.WriteLine($"Intersection point: ({x}; {y}) ");
// }
// Summ(2,5,4,9);

// Напишите программу, которая будет создавать копию заданного 2-мерного массива с помощью поэлементного копирования.
void PrintArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}
int[,] CopyNum (int[,]arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int[,] new_arr = new int[row_size, column_size];
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            new_arr[i, j] = arr[i, j];
        }
    }
    return new_arr;

}
int[,] arr_1 = MassNums(2, 5, 1, 11);
PrintArray(arr_1);
int[,] arr_1_new = CopyNum(arr_1);
PrintArray(arr_1_new);

int[,] arr_2 = MassNums(3, 6, 10, 21);
PrintArray(arr_2);
int[,] arr_2_new = CopyNum(arr_2);
PrintArray(arr_2_new); 