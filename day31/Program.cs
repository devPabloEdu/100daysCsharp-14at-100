using System;

namespace Day31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var pagamentoApple = new PagamentoApplePay();
            pagamentoApple.Pagar(20.00);
        }
    }

    public interface IPayment
    {
        DateTime Vencimento { get; set; }
        void Pagar(double valor);
    }

    public abstract class PagamentoAbstrato : IPayment
    {
        public DateTime Vencimento { get; set; }

        public virtual void Pagar(double valor)
        {
            
        }
    }

    public class PagamentoApplePay : PagamentoAbstrato
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine("Pago via Apple Pay");
        }
    }

    public class PaymentCreditCard : IPayment
    {
        public DateTime Vencimento { get; set; }

        public void Pagar(double valor)
        {
            
        }
    }

    public class Pagamento : IPayment
    {
        public DateTime Vencimento { get; set; }

        public void Pagar(double valor)
        {
           
        }
    }
}
