// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


void ShowArrayConversly(int[] arr, int i = 0)
{
    if (i == arr.Length)
    {
        return;
    }
    ShowArrayConversly(arr, i + 1);
    Console.Write($"{(arr[i])} ");
}

int [] array = {9, 45, -7, 32, 897, -65};
ShowArrayConversly(array);