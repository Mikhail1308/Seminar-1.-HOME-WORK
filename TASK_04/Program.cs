// Variant 1
// Программа показывает все четные числа в диапазоне от 1 до вводимого числа N
Console.WriteLine("Введите длинну диапазона чисел = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Четные числа в заданном диапазоне -> ");
for (int i = 2; i <= N; i = i + 2)
    Console.Write(i + "  ");
Console.WriteLine("Введите Enter для завершения");
Console.ReadLine();




// Variant 2
// Программа показывает все четные числа в диапазоне от 1 до вводимого числа N
// Console.WriteLine("Введите длинну диапазона чисел = ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Четные числа в заданном диапазоне -> ");
// var results = new List<int>();
// for (int i = 1; i <= N; i++)
// {
//     if (i % 2 == 0)
//     {
//         results.Add(i);
//     }
// }
// Console.WriteLine(string.Join(", ", results));
// Console.WriteLine("Введите Enter для завершения");
// Console.ReadLine();


// Veriant 3
// Console.Write("Write number 1: ");
// int n = int.Parse(Console.ReadLine());
// Console.Write("Write number 2: ");
// int m = int.Parse(Console.ReadLine());
// for (int i = n; i <= m; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.Write(i + " ");
//     }
// }
// Console.WriteLine("Введите Enter для завершения");
// Console.ReadLine();