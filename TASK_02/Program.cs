// Программа, которая определяет максимум из трёх введенных  чисел
Console.WriteLine("Введите число= ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число= ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число= ");
int numberC = Convert.ToInt32(Console.ReadLine());
if ((numberB < numberA) && (numberA > numberC))
{
    int numberMax = numberA;
    Console.WriteLine($"Максимальное число= {numberA}");
}

else if ((numberA < numberB) && (numberB > numberC))
{
    int numberMax = numberB;
    Console.WriteLine($"Максимальное число= {numberB}");
}
else
{
    int numberMax = numberC;
    Console.WriteLine($"Максимальное число= {numberC}");
}