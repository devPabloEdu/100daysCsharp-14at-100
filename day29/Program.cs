using System;
namespace Day29
{
    class Program
    {
        static void Main(string[] args){
            Pagamento.Vencimento = DateTime.Now;
            var payment = new Payment();
            payment.PropriedadeA();
            payment.PropriedadeB();
        }

        public static class Pagamento
        {
            public static DateTime Vencimento { get; set; }
        }

        public static class Settings
        {
            public static string API_URL {get; set;}
        }

        public sealed class PagamentoSelado
        {
            //esta classe não pode ser usada como herança.
        }
    }
}

