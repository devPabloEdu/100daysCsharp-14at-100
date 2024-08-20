using System;
namespace day26
{
    class Program
    {
        static void Main(string[] args)
        {
           var pagamento = new Pagamento(); 
           pagamento.DataPagamento = DateTime.Now;
           Console.WriteLine(pagamento.DataPagamento.ToString());
        }

    }

    public class Pagamento
    {
        public DateTime Vencimento { get; set; }

        private DateTime _dataPagamento;
        public DateTime DataPagamento
        {
            get { 
                Console.WriteLine("---Lendo um valor---");
                return _dataPagamento; 
                }

            set {
                 Console.WriteLine("___Atribuindo um valor___");   
                 _dataPagamento = value; 
                 }
        }
        
    }
}
