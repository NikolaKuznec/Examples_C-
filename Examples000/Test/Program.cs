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
// void Print(int[]arr)
// {
//     int size = arr.Length;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }
// int[] MassNums(int size)
// {
//     int[]arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(-9, 10);
//     }
//     return arr;
// }
// void SumMaxMin(int[] arr)
// {
//     int s_min, s_max;
//     s_min = s_max = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] >= 0)
//         {
//             s_max += arr[i];
//         }  
//         else 
//         {
//             s_min += arr[i];
//         }      
//     }
//     Console.WriteLine($"sum posit{s_max}, sum neg{s_min}");
// }
// int[] arr_1 = MassNums(12);
// Print(arr_1);
// SumMaxMin(arr_1);
// int[] arr_2 = MassNums(12);
// Print(arr_2);
// SumMaxMin(arr_2);



// Напишите программу замена элементов массива:
// положительны элементы заменить на соответствующие отрицательные, и на оборот. 
// 
// void Print(int[] arr)
// {
//     int size = arr.Length;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }
// int[] MassNums(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(-5, 5);
//     }
//     return arr;
// }
// void ChangeNum(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = arr[i] * -1;
//     }
// }
// int[] arr_1 = MassNums(10);
// Print(arr_1);
// ChangeNum(arr_1);
// int[] arr_2 = MassNums(10);
// Print(arr_2);
// ChangeNum(arr_2);



// Задайте массив. Напишите программу, которая определяет, присутствие ли заданное число в массиве.
// 4 [6,7,19,345,3] - > нет 
// 3 [7,7,19,345,3] - > да 
// void Print(int[] arr)
// {
//     int size = arr.Length;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }
// int[] MassNums(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(0, 10);
//     }
//     return arr;
// }
// void Search ( int num, int [] arr)
// {   string flag = ("No");
//     for (int i = 0; i < arr.Length; i++)
//     {
//          if (num == arr[i])
//          {
//               flag = "yes";
//               break; 
//          }
//     }
//     Console.WriteLine(flag);
// }
// int[] arr_1 = MassNums(10);
// Print(arr_1);
// Search(5, arr_1);
// int[] arr_2 = MassNums(10);
// Print(arr_2);
// Search(5, arr_2);



// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значение которых лежат в отрезке [10,99] 
// void PrintArray(int[] arr)
// {
//     int size = arr.Length;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine(arr[size - 1]);
// }
// int[] MassNums(int size)
// {
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(0, 20);
//     }
//     return arr;
// }
// int[] arr = MassNums(20);
// int count = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] < 100 && arr[i] >= 10) count++;
// }
// Console.WriteLine(count);
// PrintArray(arr);



// Урок №6 Двухмерные массивы и рекурсия. 
// Задача №1 напишите программу, которая перевернёт одномерный массив.
//  (последний элемент будет на первом месте, а первый - на поледнем и ТД. )
// void PrintArray(int[] arr)
// {
//     int size = arr.Length;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine(arr[size - 1]);
// }
// int[] MassNums(int size, int from, int to)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(from, to);
//     }
//     return arr;
// }
// int[] RevMas(int[] arr)
// {
//     int size = arr.Length - 1;
//     for (int i = 0; i < size / 2 + 1; i++)
//     {
//         (arr[i], arr[size - i]) = (arr[size - i], arr[i]);
//     }
//     return arr;
// }
// int[] arr_1 = MassNums(8, 5, 21);
// PrintArray(arr_1);
// RevMas(arr_1);
// PrintArray(arr_1);




// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник 
// со сторонами такой длинны. 
// string check(int a, int b, int c)
// {
//     if (a < b + c && b < a + c && c < a + b)
//     return "no";
//     return "yes";
// }
// Console.WriteLine (check(4,6,7));



//  Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// void binary(int num)
// {
//     string i = "";
//     while (num > 0)
//     {
//         i = num % 2 + i;
//         num = num / 2;
//     }
//     Console.Write(i);
// }
// binary(2);


// Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначи: 0 и 1.
// void Fibonacci(int num)
// {
//     int a = 0;
//     int b = 1;
//     for (int i = 0; i < num; i++)
//     {      
//         Console.Write($"{a} ");
//         (a, b) = (b, a + b);
//     }
// }
// Fibonacci(7);

// int For(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }
// Console.WriteLine(For (2, 10));
// 
// /string path = "";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);

// void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} -- {on} " );
//     if (count > 1) Towers(with, some, on, count - 1);
// }

// Towers();

// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// //                  0   1    2    3    4     5    6    7    8    9    10   11 

// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         // Console.Write(tree[pos]);
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         // Console.Write(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//         // Console.Write(tree[pos]);   

//     }
// }
// InOrderTraversal();