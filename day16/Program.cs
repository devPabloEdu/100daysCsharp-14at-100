using System;

class SelectionSortExample
{
    static void Main()
    {
        int[] array = { 64, 25, 12, 22, 11 };

        Console.WriteLine("Array original:");
        PrintArray(array);

        SelectionSort(array);

        Console.WriteLine("\nArray ordenado:");
        PrintArray(array);
    }

    static void SelectionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
