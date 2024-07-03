using System;

namespace daysCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            SearchName(); 
        }

        static void SearchName()
        {
            var nameList = new string[] {"Romarinho", "Cassio", "Tupanzinho", "Edilson", "Ronaldo"};
            var correctName = "Ronaldo";
            var found = false;

            for (int i = 0; i < nameList.Length; i++)
            {
                if (correctName == nameList[i])
                {
                    Console.WriteLine($"O nome {correctName}, foi encontrado na lista na posição {i}.");
                    found = true;
                    break; // Sai do loop assim que o nome é encontrado.
                }
            }

            if (!found)
            {
                Console.WriteLine("O nome não existe na lista!");
            }
        }
    }
}
