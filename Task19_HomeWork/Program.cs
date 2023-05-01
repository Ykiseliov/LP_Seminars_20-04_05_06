Console.Write("Введите пятизначное число: ");
        int number = int.Parse(Console.ReadLine());

        int first = number / 10000;
        int second = number / 1000 % 10;
        int fourth = number % 100 / 10;
        int fifth = number % 10;

        if (first == fifth && second == fourth)
        {
            Console.WriteLine("Число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом.");
        }