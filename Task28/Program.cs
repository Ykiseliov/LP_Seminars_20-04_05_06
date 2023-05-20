// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= n; i++)
// {
//     result *=i;
// }
// Console.WriteLine($"Произведение чисел от 1 до {n} равно {result}");

//Второе решение
Console.WriteLine("Bведите натуральное число N");

int number = Convert.ToInt32(Console.ReadLine());

if (number <=0) Console.WriteLine("введено не натуральное число");

else
{
	int factorial = Factorial(number);
	Console.WriteLine($"Факториал числа {number} равен {factorial}");
}

int Factorial(int num)
{
	int fact = 1;

	for (int i=1; i <= num; i++)
	{
		checked
		{
			fact = fact * i;
		}
	}
	return fact;
}