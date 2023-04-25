// Напишите прогрумму, которая выводит случайное трехзначное
//  число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 ->72
// 918 -> 98

int number = new Random().Next(100, 1000); //(10, 99 + 1)
Console.WriteLine($"Случайное число из отрезка 100 - 1000 -> {number}");

int RemSecDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int ourDigit = firstDigit * 10 + thirdDigit;
    return ourDigit;
    // return firstDigit > secondDigit ? firstDigit:secondDigit;
}   
int result = RemSecDigit(number);
Console.WriteLine($"{number} -> {result}");