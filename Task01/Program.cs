// Напишите прогр-му, которая принимает на вход два числа и проверяет, является ли первое квадратом второго

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b)
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine("Не является");
}
