// Задайте масив заполненный случайными положительными трехзначным числами. 
// Напишите программу, которыя покажет количество чётных чисел в массиве. 

// void PrintArray(int[] arr)
// {
//     int size = arr.Length;

//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine(arr[size - 1]);
// }
// int[] MassNums(int size, int s_min, int s_max )
// {
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(s_min,s_max);
//     }
//     return arr;
// }
// int KountNum(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i]%2 ==0)
//         {
//             count+=1;
//         }
//     }
//     return count;
// }

// int[] arr_1 = MassNums(5,100,253);
// PrintArray(arr_1);
// Console.WriteLine(KountNum(arr_1));

// int[] arr_2 = MassNums(5,200,310);
// PrintArray(arr_2);
// Console.WriteLine(KountNum(arr_2));

// 2)Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// void PrintArray(int[] arr)
// {
//     int size = arr.Length;

//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine(arr[size - 1]);
// }
// int[] MassNums(int size, int s_min, int s_max)
// {
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(s_min, s_max);
//     }
//     return arr;
// }
// int KountNum(int[] arr)
// {
//     int count = 0;
//     for (int i = 1; i < arr.Length; i += 2)
//     {
//         count += arr[i];
//     }
//     return count;
// }

// int[] arr_1 = MassNums(5, 1, 10);
// PrintArray(arr_1);
// Console.WriteLine(KountNum(arr_1));

// int[] arr_2 = MassNums(5, 2, 30);
// PrintArray(arr_2);
// Console.WriteLine(KountNum(arr_1));

// 3)Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// void PrintArray(double[] arr)
// {
//     int size = arr.Length;

//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }
// double[] MassNums(int size)
// {
//     double[] arr = new double[size];
//     Random n_new = new Random();

//     for (int i = 1; i < size; i++)
//     {
//         arr[i] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2);
//     }
//     return arr;
// }
// void NumMinMax(double[] arr)
// {
//     double n_min = arr[0];
//     double n_max = arr[0];
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (n_min > arr[i])
//         {
//             n_min = arr[i];

//         }
//         else if (n_max < arr[i])
//         {
//             n_max = arr[i];
//         }
//     }
//     Console.Write($"Max:{n_max}, Min:{n_min}.  ");
//     Console.WriteLine($"NumMinMax:{n_max}-({n_min}))={Math.Round(n_max - n_min, 2)}");
// }
// double[] arr_1 = MassNums(10);
// PrintArray(arr_1);
// NumMinMax(arr_1);

// double[] arr_2 = MassNums(10);
// PrintArray(arr_2);
// NumMinMax(arr_2);

// 4)Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 11);
    }
    return arr;
}

int[] PairsNum(int[] arr)
{
    int size = arr.Length;
    int[] new_arr = new int[size / 2];

    if (size % 2 == 1)
    {
        new_arr = new int[size / 2 + 1];
        new_arr[new_arr.Length - 1] = arr[size / 2];
    }

    for (int i = 0; i < size / 2; i++)
    {
        new_arr[i] = arr[i] * arr[size - i - 1];
    }

    return new_arr;
}

int[] arr_1 = MassNums(5);
Print(arr_1);
int[] arr_1_new = PairsNum(arr_1);
Print(arr_1_new);

int[] arr_2 = MassNums(6);
Print(arr_2);
int[] arr_2_new = PairsNum(arr_2);
Print(arr_2_new);