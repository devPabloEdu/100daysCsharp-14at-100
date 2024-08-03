using System;
class InsertionSortExample
{
    static void Main()
    {
        int[] lista = { 64, 25, 12, 22, 11 };
         Console.WriteLine("Array original:");
        PrintArray(array);

        InsertionSort(array);

        Console.WriteLine("\nArray ordenado:");
        PrintArray(array);
    }
    static void InsertionSort(int lista){
        var n = Length(int lista);
        for i in range(1, n){
            chave = int lista[i];
            var j = i - 1;
            while j >= 0 && int lista{j} > chave{
                int lista[j+1] = int lista[j];
                j = j - 1;
            }
            int lista[j+1] = chave;
        }
    }
}