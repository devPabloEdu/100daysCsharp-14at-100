using System;
namespace Day37
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var payment = new Payment();
            var subscription = new Subscription();
            var context = new DataContext<Person, Payment, Subscription>();
            context.Save(person);
            context.Save(payment);
            context.Save(subscription);
            

        }
    }

    public class DataContext<P, PA, S> 
        where P : Person
        where PA : Payment
        where S : Subscription
    {
        public void Save(P entity)
        {
            Console.WriteLine("Person salvo!");
        }

         public void Save(PA entity)
        {
            Console.WriteLine("Payment salvo!");
        }

         public void Save(S entity)
        {
            Console.WriteLine("Subscription salvo!");
        }
    }

    public class Person()
    {
        
    }

    public class Payment
    {

    }

    public class Subscription
    {

    }
}