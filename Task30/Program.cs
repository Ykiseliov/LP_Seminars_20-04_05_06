// Задача 30: Напишите программу, которая выводит 
// массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

int[] arr = new int[8];

FillArray(arr); 
Console.Write("["); 
PrintArray(arr); 
Console.Write("]");

void PrintArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
    Console.Write($"{array[i]}");
    }

}

void FillArray (int[] array)
{
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
}