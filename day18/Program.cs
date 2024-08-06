using System;
class BubbleSortExample
{
    static void Main(){
    
    int[] array = {4, 9, 2, 1, 7, 8};
    Console.WriteLine("Array original:");
        PrintArray(array);

        BubbleSort(array);

        Console.WriteLine("\nArray ordenado:");
        PrintArray(array);
    }
    static void BubbleSort(int[] array)
    {
        int size = array.Length;
        for(int num = 0; num < size - 1; num++)
        {
        for (int i = 0; i < size-1 - num - 1; i++)
        {
            if (array[i] > array[i+1])
            {
                int temp = array[i+1];
                array[i+1] = array[i];
                array[i] = temp;
            }
        }
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}



    