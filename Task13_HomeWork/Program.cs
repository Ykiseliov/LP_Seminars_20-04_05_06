//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

    Console.Write("Введите число: ");
        int number =  Convert.ToInt32(Console.ReadLine());
        if (number >= 100 && number <= 999) 
         {
             int thirdDigit = number % 10;
             Console.WriteLine($"Третья цифра числа {number} будет {thirdDigit}");
         }
         else if (number >= 1000 && number <= 9999) {
            int thirdDigit = (number / 10) %10;
            Console.WriteLine($"Третья цифра числа {number} будет {thirdDigit}");
        } 
         else if (number >= 10000 && number <= 99999) 
         {
             int thirdDigit = (number / 100) % 10;
             Console.WriteLine($"Третья цифра числа {number} будет {thirdDigit}");
         }

        else
        {
            Console.WriteLine("У числа нет третьей цифры.");
        }
