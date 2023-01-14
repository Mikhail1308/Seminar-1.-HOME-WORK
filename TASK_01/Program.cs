// Программа поиска наибольшего и наименьшего, из двух введенных чисел
Console.WriteLine("Введите число= ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число= ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"Максимальное число= {numberA} Минимальное число= {numberB}");
}
else
{
    Console.WriteLine($"Максимальное число= {numberB} Минимальное число= {numberA}");
}