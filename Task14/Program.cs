// 14. Напишите программу, которая принимает на 
// вход число и проверяет, кратно ли оно одновременно 7 и 23

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Multiplicity(number);
Console.WriteLine(result ? "Да" : "Нет");

bool Multiplicity(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}