// void Quarters(int x, int y)
// {
//     if (x > 0)
//     {
//         if (y > 0)
//         {
//             Console.WriteLine("I");
//         }
//         else if (y < 0)
//         {
//             Console.WriteLine("IV");
//         }

//     }
//     else if (x < 0)
//     {
//         if (y > 0)
//         {
//             Console.WriteLine("II");
//         }
//         else if (y < 0)
//         {
//             Console.WriteLine("III");
//         }

//     }

// }
//     Quarters(2, 2);
//     Quarters(-2, 2);
//     Quarters(-2, -2);
//     Quarters(2, -2);
//     Quarters(0, -2);
//     Quarters(2, 0);
//  Программ по определению 2 х точек. 
// void Quarters(int x, int y)
// {
//     if (x == 0 || y == 0)
//     {
//         Console.WriteLine("x = 0, y = 0");
//     }
//     else if (x > 0 & y > 0)
//     {
//         Console.WriteLine("I");
//     }
//     else if (x < 0 & y > 0)
//     {
//         Console.WriteLine("II");
//     }
//     else if (x < 0 & y < 0)
//     {
//         Console.WriteLine("III");
//     }
//     else if (x > 0 & y < 0)
//     {
//         Console.WriteLine("IV");
//     }
// }
// Quarters(2, 2);
// Quarters(-2, 2);
// Quarters(-2, -2);
// Quarters(2, -2);
// Quarters(0, -2);
// Quarters(2, 0);
//
// задача 

// double distance(int x1, int y1, int x2, int y2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)),4);

// }
// Console.WriteLine(distance(3, 6, 2, 1));
// 
// Задача №3 Напишите програаму, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N 
//
// void Squares(int num)
// {
//     Console.Write($"{num} - >");
//     int i = 1;

//      while (num >= i)
//     {
//         Console.Write(Math.Pow(i, 2));
//         i++;
//     }
// }
// Squares(5);
// Squares(7);
//
// Урок 4 Функции продолжение. 
// Напишите программу, которая принимает на вход число (А) и выдает суммц чисел от 1 до А.
// 
// int SumNum(int num)
// {
//     int all_sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         all_sum += i;
//     }
//     return all_sum;

// }

// Console.WriteLine(SumNum(4));
// Console.WriteLine(SumNum(8));
// Console.WriteLine(SumNum(2));
// 
// Напишите программу, которая принимает число на вход число и выдает количество цифр в числе.
// вариант №1
// void sum(int num)
// {
//     int i = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         i = i + 1;
//     }

//     Console.WriteLine(i);
// }
// sum(12345);
// 
// Вариант №2 
// int sum (int num)
// {
//     string result = num.ToString();
//     return result.Length;
// }

// Console.WriteLine(sum(1234));
// Console.WriteLine(sum(123));
// Console.WriteLine(sum(54322));
// 
// Напишите пограмму, которая принимает на вход число N и выводаёт произведение чисел от 1 до N
// 
// int PowNum(int num)
// {
//     int all_pow = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         all_pow *= i;
//     }

//     return all_pow;
// }
// Console.WriteLine(PowNum(5));
// 
// Напишите программу, которая выводит массив из 8элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// 
// int[] array = new int[8];
// for (int i = 0; i < 8; i++)
// {
//     array[i] = new Random().Next(2);
//     Console.Write($"{array[i]}|, ");
// }
// 
// Урок 5 Функции продолжение. 
//  Сортировка по убыванию 
// void Print(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}  ");
//     }
//     Console.WriteLine();
// }
// void SelectionSort(int[] arr)
// {
//     int size = arr.Length;
//     for (int i = 0; i < size - 1; i++)
//     {
        
//         int n_max = i;
//         for (int j = i + 1; j < size; j++)
//         {
//          if (arr[n_max] > arr[j])
//            {
//              n_max = j;
//            }  
//         }
//       (arr[i], arr[n_max]) = (arr[n_max], arr[i]);
        
//     }
// }
// int[] my_arr = { 78, -32, 5, 39, 59, -7, -78, 3, 76, };
// Print(my_arr);
// SelectionSort(my_arr);
// Print(my_arr);
// 
// 1) Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]
//    найдите сумму отрицательных элементов массива. 
// 




