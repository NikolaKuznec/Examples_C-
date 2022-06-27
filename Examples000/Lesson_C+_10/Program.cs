//Дано натуральное число N. Выедите все оге цифры по одной, в обратном порядке, разделяя их
//  пробелами или новыми стоками. 
// void ValueSet(int n)
// {
//     if (n % 10 < 1) return;
// Console.Write($"{n % 10}-");
// ValueSet(n / 10);
// }
// ValueSet(1234);
// Console.WriteLine();

// Задача № 1 Напишите программу, которая на вход принимает два числа и выдает 
//  первые N чисел, для которых каждое следующее расно сумме двух предыдущих. 
// int ValueSet(int n, int m, int s)
// {
//     if (s == 1) return n;
//     Console.Write($"{n} - ");
//     // (n, m) = (m, m + n); оптимизация в ретерн 
//     return ValueSet(m, m + n, s - 1);
// }
// Console.WriteLine(ValueSet(3, 4, 5));

//  Задача №2 В некотором машинном алфавите имеются четыре буквы "а", "и " " с "  и 
//  "в". Покажите все слова,состоящие из N букв, которые можно построить из букв этого алфавита.
char[] massiv = { 'а', 'и', 'с', 'в'};
int count = 2;
void FintWords(char[] search, char[] dict, int m = 0)
{
    if (m == dict.Length)
    {
        Console.WriteLine($"{m} :{new String(dict)} ");
        return;
    }
    for (int i = 0; i < search.Length; i++)
    {
        dict[m] = search[i];
        FintWords(search, dict, m + 1);
    }
}
FintWords(massiv, new char[count]);
