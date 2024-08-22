using System;
namespace day28
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var pagamento = new Pagamento())
            {
                Console.WriteLine("Processando o pagamento");
            }
        }
    }

    public class Pagamento : IDisposable
    {
        public Pagamento()
        {
            Console.WriteLine("iniciando o pagamento");
        }

        public void Dispose()
        {
           Console.WriteLine("Finalizando o pagamento");
        }
    }
}
