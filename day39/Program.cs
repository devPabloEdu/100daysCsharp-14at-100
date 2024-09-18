using System;
using System.Collections.Generic;
using System.Linq;

namespace Day39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var payments = new List<Payment>();
            payments.Add(new Payment(1));
            payments.Add(new Payment(2));
            payments.Add(new Payment(3));
            payments.Add(new Payment(4));
            payments.Add(new Payment(5));

            foreach (var item in payments)
            {
                Console.WriteLine($"Listando : {item.Id}");
            }

            var payment = payments.First(x=>x.Id == 3);
            Console.WriteLine(payment.Id);
            var exists = payments.Any(x=>x.Id == 3);
            Console.WriteLine(exists);

            payments.Remove(payment);
            foreach (var item in payments)
            {
                Console.WriteLine($"Listando : {item.Id}");
            }
            var exists2 = payments.Any(x=>x.Id == 3);
            Console.WriteLine(exists2);
            //APRENDENDO SOBRE O RANGE
            //var paidPayments = new List<Payment>();
            //paidPayments.AddRamge(payments);
        }
    }

    public class Payment 
    {
        public int Id { get; set; }
        public Payment(int id)
        {
            Id = id;
        }
     }
}
