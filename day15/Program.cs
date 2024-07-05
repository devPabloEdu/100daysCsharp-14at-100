using System;

namespace daysCsharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int item = 12;
            int result = BinarySearch(array, item, 0, array.Length - 1);
            
            if (result != -1)
            {
                Console.WriteLine($"Item {item} encontrado no índice {result}.");
            }
            else
            {
                Console.WriteLine("Item não encontrado.");
            }
        }

        static int BinarySearch(int[] array, int item, int begin, int end)
        {
            if (begin <= end)
            {
                int mid = (begin + end) / 2;

                if (array[mid] == item)
                {
                    return mid;
                }
                else if (item < array[mid])
                {
                    return BinarySearch(array, item, begin, mid - 1);
                }
                else
                {
                    return BinarySearch(array, item, mid + 1, end);
                }
            }

            return -1; // Item não encontrado
        }
    }
}
