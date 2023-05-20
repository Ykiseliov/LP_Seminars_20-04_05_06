//Exmpl2 - Замена букв
// string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
//             +"ежели бы вас послали вместо нашего милого Винцена,"
//             +"вы бы взяли приступом согласие прусского короля."
//             +"Вы так красноречивы. Вы дадите мне чаю?";

// //string s = "qwerty"
// //            012    
// // s = 3 //r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ','-');
// System.Console.WriteLine(newText);
// string newText1 = Replace(text, 'к','К');
// System.Console.WriteLine(newText1);
// string newText2 = Replace(text, 'с','С');
// System.Console.WriteLine(newText2);

//Exmpl3 - Массивы
int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void  PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < 0; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length - 1; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int tempopary = array[i];
        array[i] = array[minPosition];
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);