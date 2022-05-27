// Задача № 1: Напишите цикл котрый принемает на вход два числа ( А и В ) и возводит число А 
//             в наруральную степень В 3, 5 = 243(3 %5); 2, 4 = 16. 
// 
// int Num(int a, int b)
// {
//     int num_S = a;
//     for (int i = 1; i < b; i++)
//     {
//         num_S *= a;
//     }
//     return num_S;

// }
// Console.WriteLine(Num(3,5)); 
// Console.WriteLine(Num(2,4));

// Задача № 2: Напишите программа, которая пронимает на вход число и выдает сумму цифр в числе. 
//               452 = 11: 82 = 10: 9012 = 12:

// int sum(int num)
// {
//     int i = 0;
//     while (num > 0)
//     {
//         i += num % 10;
//         num /= 10;
//     }

//     return i;
// }
// Console.WriteLine(sum(452));
// Console.WriteLine(sum(82));
// Console.WriteLine($"{sum(9012)}->");

// Задача № 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
//             Оформите заполнение массива и вывод в виде фунции ( пригодиться в следующих задачах.)
//              1,2,5,7,19,1,2,8, = 1,2,5,7,19,1,2,8 : 6,1,33,5,6,7,7,1,= 6,1,33,5,6,7,7,1 :

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();

}
int[] EighiMass()
{
    int size = 8;
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1,100);
    }
    return arr;

}
int []arr_1 = EighiMass();
Print(arr_1);
int []arr_2 = EighiMass();
Print(arr_2);

//  Если честно последнюю задачу полностью списал, не смог сам сделать...(((