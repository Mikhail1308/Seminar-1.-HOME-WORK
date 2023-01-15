// Программа показывает все четные числа в диапазоне от 1 до вводимого числа N
Console.WriteLine("Введите длинну диапазона чисел = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Четные числа в заданном диапазоне -> ");
var results = new List<int>();
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        results.Add(i);
    }
}
Console.WriteLine(string.Join(", ", results));
Console.WriteLine("Введите Enter для завершения");
Console.ReadLine();