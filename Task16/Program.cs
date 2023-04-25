// Напишите прогр-у, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да

Console.Write("Enter 1 num: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2 num: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = IsSquare(number1, number2);
Console.WriteLine(result ? "да":"нет");

bool IsSquare (int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}