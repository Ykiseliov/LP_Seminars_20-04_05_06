//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = GetThirdDigit(number);

int GetThirdDigit(int number)
{
    string numberString = number.ToString(); // переводим число в строку
    if (numberString.Length < 3) // проверяем длину строки
    {
        Console.WriteLine("У числа меньше трёх цифр.");
        return -1;  // возвращаем несуществующую цифру
    }
    int thirdDigit = Convert.ToInt32(numberString[2].ToString()); // получаем третью цифру, начиная с индекса 2 (третья цифра имеет индекс 2)
    return thirdDigit;
}
if (thirdDigit != -1)
{
    Console.WriteLine($"Третья цифра числа {number} - это {thirdDigit}");
}
