// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// string summ = Console.ReadLine();
// int a = int.Parse(summ);
// int x;
// x = a  / 10 % 10;
// Console.WriteLine(x);
//
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// void NumRendom()
// {
//     int summ = new Random().Next(100, 1000);
//     Console.WriteLine($"{summ}- ={summ / 100}{summ % 10}");
// }
// NumRendom();
//
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//

// void ThirNum(int summ)
// {
//     Console.Write($"{summ} -= ");
//     int rt_summ = 0;
//     string txt;

//     while (summ > 99)
//     {
//         rt_summ = summ % 10;
//         summ = summ / 10;
//     }
//     txt = $"{rt_summ}";
//     if (rt_summ == 0)
//     {
//         txt = "the amount is two-digit";
//     }
//     Console.WriteLine(txt);
// }

// ThirNum (18);ThirNum (237600);
//
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Weekend (int num)
{
    string txt = "weekday ";

    if (num == 7 | num == 6)
    {
        txt = "weekend";
    }
    if (num > 7)
    {
        txt = "error";
    }
    Console.WriteLine($"{num} - = {txt}");
}
 Weekend(7); Weekend(87); Weekend(5);

