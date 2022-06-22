//  Задача №1 Задайте значения M и N. Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// void AllEvenNumers(int M, int N)
// {
//     if (M > N) return;
//     if (M % 2 == 1) M += 1;
//     Console.Write($"{M} - ");
//     AllEvenNumers(M + 2, N);    
// }
// AllEvenNumers(1, 5);
// Console.WriteLine();
// AllEvenNumers(4, 8);


// 2. Задайте значения M и N. Напишите программу, которая найдёт сумму
//    натуральных элементов в промежутке от M до N с помощью рекурсии.
int AllNumersSum(int M, int N)
{
    if (M > N) return 0;    
    return AllNumersSum(M, N - 1) + N;
}

Console.WriteLine(AllNumersSum(1, 15));
Console.WriteLine(AllNumersSum(4, 8));

