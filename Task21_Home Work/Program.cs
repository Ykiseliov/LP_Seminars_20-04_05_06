// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Координаты точки 1:");
            Console.Write("x: ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("z: ");
            double z1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Координаты точки 2:");
            Console.Write("x: ");
            double x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            double y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("z: ");
            double z2 = Convert.ToInt32(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

            Console.WriteLine($"Расстояние между 1 и 2 точками: {distance:F2}");