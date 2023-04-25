// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = number%10;
Console.WriteLine($"Ваше число {number}, его последняя цифра {lastDigit}");