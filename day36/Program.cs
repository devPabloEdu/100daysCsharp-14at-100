using System;
namespace Day36
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var context = new DataContext<Person>();
            context.Save(person);

        }
    }

    public class DataContext<T>
    {
        public void Save(T entity)
        {
            Console.WriteLine("Dado salvo!");
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