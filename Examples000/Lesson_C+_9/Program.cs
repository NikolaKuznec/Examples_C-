//  1 Задайте значение N. Напишите программу, которая выведет 
//  все натуральные числа в промежутке от 1 до N при помощи рекурсии. 
// void ValueSet(int num)
// {
//     if (num == 0) return;
//     // ValueSet ( num - 1);
//     Console.Write($"{num },");
//     // ValueSet ( num - 1);
// }
// ValueSet(5);

//  2. Задайте значение M и N . Напишите программу, 
//   которая рекурсивно выведет все натуральные числа в промежутке от M до N. 
// void ValueSet(int n, int m)
// {
//     if (n > m) return;
//     // ValueSet(n, m - 1);
//     Console.Write($"{m},-");
//     // ValueSet(n, m - 1);
// }
// ValueSet(5, 10);

//  3 Напишите программу, которая ,которая будет принимать на вход число
//  и возвращать сумму его цифр.  
// int ValueSet(int num )
// {
//     if (num == 0) return 0 ;
//     return ValueSet(num / 10 ) + num % 10;  
// }
// Console.Write(ValueSet(4321));



//  4 Напишите программу, которая на вход принимает два числа А и В, 
// и возводит число А в целую степень В с помощью рекурсии. 
// int ValueSet(int a, int b)
// {
//     if (b == 0)
//     {
//         return 1 ;
//     }
//     return ValueSet(a, b - 1) * a;
// }
// Console.WriteLine(ValueSet(3, 5));