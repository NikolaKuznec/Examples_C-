// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void Palindme(int a)
// {
//     string num = a.ToString();
//     int size = num.Length - 1;
//     string flag = "Yes";
//     int i = 0;

//     while (i < size / 2)
//     {
//         if (num[i] !=num[size - i])
//         {
//             flag = "No";
//             break;
//         }
//         i ++;
//     }
//     Console.WriteLine($"{a} - = {flag}");

// }
// Palindme(1238321);
// Palindme(321435);
// Palindme(4432233);
//
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//
// double segment3D(float x1, float y1, float z1, float x2, float y2, float z2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) +
//     Math.Pow(y1 - y2, 2) + 
//     Math.Pow(z1 - z2, 2)), 2);
// }

// Console.WriteLine(segment3D(4,7,9,3,2,-8));
// Console.WriteLine(segment3D(7,-5,0,1,-1,9));
// Console.WriteLine(segment3D(4,-6,2,8,-2,7));
//
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//
void Squares(int num)
{
    Console.Write($"{num} - =");
    int i = 1;

    while (num >= i)
    {
        Console.Write(Math.Pow(i, 3));
        i++;
    }
}
Squares(12);
