using System;
class InsertionSortExample
{
    static void Main()
    {
        int[] array = { 64, 25, 12, 22, 11 };
        Console.WriteLine("Array original:");
        PrintArray(array);

        InsertionSort(array);

        Console.WriteLine("\nArray ordenado:");
        PrintArray(array);
    }
    static void InsertionSort(int[] array)
    {
        int size = array.Length;
        for(int i = 1; i < size; i++)
        {
            int chave = array[i];
            int j = i -1;
            while(j >= 0 && array[j] > chave)
            {
                array[j+1] = array[j];
                j--;
            }
            array[j+1] = chave;
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