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