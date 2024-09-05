using System;
namespace Day34
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Delegates => Metodos Anonimos
            var pagar = new Pagamento.Pagar(RealizarPagamento);
            pagar(30);
            var pagarCartao = new Pagamento.Pagar(RealizarPagamentoCartão);
            pagarCartao(15);
        }

         static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pago o valor de {valor}");
        }

        static void RealizarPagamentoCartão(double valor)
        {
            Console.WriteLine($"Pago o valor de {valor} reais via cartão.");
        }
    }

    public class Pagamento
    {
        public delegate void Pagar(double valor);
    }
}