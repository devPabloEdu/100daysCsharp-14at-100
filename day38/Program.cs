using System;
using System.Collections.Generic;

namespace Day38
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payment> payments = new List<Payment>();
            payments.Add(new Payment());

            var lista = new List<string>();

            Jogadores();
        }

        public static void Jogadores()
        {
            Console.Clear();
            List<string> names = new List<string>();
            names.Add("Talles Magno");
            names.Add("Rodrigo Garro");
            names.Add("Depay");
            names.Add("Yuri Alberto");
            names.Remove("Yuri Alberto");
            names.Add("André Ramalho");
            foreach (var name in names)
            {
                Console.WriteLine($"Craque: {name.ToUpper()}");
            }
        }
    }

    public class Payment { }
}
