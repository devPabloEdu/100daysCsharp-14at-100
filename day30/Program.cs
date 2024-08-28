using System;
namespace Day30
{
   class Program
   {
    static void Main(string[] args)
    {

    }
   } 

   public class PaymentCreditCard : IPayment
   {
    DateTime Vencimento { get; set; }

    void Pagar(double valor);
   }
   public class Pagamento : IPayment
   {
    DateTime Vencimento { get; set; }

    void Pagar(double valor);
   }

   public interface IPayment
   {
    DateTime Vencimento { get; set; }

    void Pagar(double valor);
   }
}
