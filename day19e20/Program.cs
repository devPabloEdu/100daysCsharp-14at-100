using System;

class MergeSortExample
{
    static void Main(string[] args)
    {
        int[] array = { 4, 7, 2, 6, 5, 1, 8, 3 }; // Correção na inicialização do array
        int inicio = 0;
        int fim = array.Length - 1; // Correção na definição de fim

        Console.WriteLine("Array original:");
        PrintArray(array);

        MergeSort(array, inicio, fim);

        Console.WriteLine("\nArray com Merge Sort:");
        PrintArray(array);
    }

    static void MergeSort(int[] array, int inicio, int fim)
    {
        if (inicio < fim)
        {
            int meio = (inicio + fim) / 2;
            MergeSort(array, inicio, meio);
            MergeSort(array, meio + 1, fim);
            Merge(array, inicio, meio, fim);
        }
    }

    static void Merge(int[] array, int inicio, int meio, int fim)
    {
        int[] left = new int[meio - inicio + 1];
        int[] right = new int[fim - meio];

        Array.Copy(array, inicio, left, 0, left.Length);
        Array.Copy(array, meio + 1, right, 0, right.Length);

        int i = 0, j = 0, k = inicio;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                array[k++] = left[i++];
            }
            else
            {
                array[k++] = right[j++];
            }
        }

        while (i < left.Length)
        {
            array[k++] = left[i++];
        }

        while (j < right.Length)
        {
            array[k++] = right[j++];
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
