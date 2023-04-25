// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Bведите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Bведите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Bведите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine($"Максимальное число: {max}");
