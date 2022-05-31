// Певый вид методов 
// void Method1()
// {
//     Console.WriteLine("Кузнецов Н.В");
// }
// Method1();
// 
//  Метот 2 
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2("текст ");
// void Method21(string msg, int count)
// {
//     int i = 1;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i ++;
//     }
//     Console.WriteLine(msg );
//     Console.WriteLine( ); 

// }
// Method21(msg:"текст", count: 4);
// Method21(msg:"парабула ", count: 4);

// Метод 3 
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int uear = Method3();
// Console.WriteLine(uear);
// 

// Метод  4 
// String Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;  
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);
// 
//  Синтаксис Цикла ( For ) 

// String Method4(int count, string text)
// {
//     string result = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "asdf  ");
// Console.WriteLine(res);

// Использование цикла ( for + c внутренним циклом тоже for )
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($" {i} x {j} = {i * j}");
//     }
//     Console.WriteLine();

// }
//  в тексте нужно все пробелы заменить на черточки, маленькие буквы (к) заменить на (К) большие, 
// а большие (С) заменить на маленьки (с).
// String text = "клиенты обязаны предоставлять организациям, осуществляющим операции"
// + " с денежными средствами или иным имуществом, информацию, необходимую для исполнения"
// + " указанными организациями требований настоящего Федерального закона, включая информацию"
// + " о своих выгодоприобретателях и бенефициарных владельцах";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int Length = text.Length;
//     for (int i = 0; i < Length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newtext = Replace(text,'к', 'К');
// Console.WriteLine(newtext);
// Console.WriteLine(2);

// newtext = Replace(newtext, ' ', '|');
// Console.WriteLine(newtext);
// Console.WriteLine(3);

// newtext = Replace(newtext, 'с', 'С');
// Console.WriteLine(newtext);

// Сортировка массива. по наростающи и убывающий цикл. 
// int[] arr = { 1, 3, 5, 8, 2, 4, 1, 1 };
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// void SelectionSortMin(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// void SelectionSortMax(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int MaxPosition = i;

//         for (int j = i; j < array.Length; j++)
//         {
//             if (array[j] > array[MaxPosition]) MaxPosition = j;
//         }
//         int tempor = array[i];
//         array[i] = array[MaxPosition];
//         array[MaxPosition] = tempor;
//     }
// }
// PrintArray(arr);
// SelectionSortMin(arr);

// PrintArray(arr);
// SelectionSortMax(arr);

// PrintArray(arr);

