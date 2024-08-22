using  System;
namespace day27
{
   class Program
   {
    static void Main(string[] args)
    {
        var pagamento = new PagamentoCartao();
        pagamento.Pagar("123");

        Console.WriteLine("----------");

        var pagamento2 = new Pagamento();
        pagamento2.Pagar("123");
    }
   } 
   public class Pagamento
   { 
    public Pagamento()
    {
        Console.WriteLine("Iniciando o Pagamento");
    }
    public virtual void Pagar(string numeroDoBoleto)
    {
        Console.WriteLine("Pagar com boleto");
    }
   }
   public class PagamentoCartao : Pagamento
   {
    public override void Pagar(string numeroDoCartão)
    {
        Console.WriteLine("Pagar com cartão.");
    }
   }
}
