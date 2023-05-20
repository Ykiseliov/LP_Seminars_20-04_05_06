
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