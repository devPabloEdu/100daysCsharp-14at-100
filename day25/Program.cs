using System;
namespace day25
{
   class Program
   {
    static void Main(string[] args)
    {
        Console.Clear();
        PagamentoCartao pagamentoCartao = new PagamentoCartao();
        pagamentoCartao.Vencimento = DateTime.Now;
        pagamentoCartao.NumeroDoCartão = "12345678910";
        pagamentoCartao.CodigoDeSegurança ="456";
        pagamentoCartao.ValidadeDoCartão = "05/25";
        pagamentoCartao.Pagar();
        Console.WriteLine("Número do Cartão: " + pagamentoCartao.NumeroDoCartão);
        Console.WriteLine("Validade: " + pagamentoCartao.ValidadeDoCartão);
        Console.WriteLine("Código de Segurança: " + pagamentoCartao.CodigoDeSegurança);
        Console.WriteLine("Data de Vencimento: " + pagamentoCartao.ToString());

    }

   }

   class Pagamento
   {
    public DateTime Vencimento;
    public virtual void Pagar()
    {
        Console.WriteLine("Pagamento processado.");
    }

    public override string ToString()
    {
        return Vencimento.ToString("dd/mm/yy");
    }
   } 

   class PagamentoBoleto : Pagamento
   {
    public string NumeroDoBoleto;

    public override void Pagar()
    {
        //REGRA DO BOLETO
        Console.WriteLine("Pago via Boleto");
    }
   }

   class PagamentoCartao : Pagamento
   {
    public string NumeroDoCartão;
    public string ValidadeDoCartão;
    public string CodigoDeSegurança;

    public override void Pagar()
    {
        //regra do cartão
        Console.WriteLine("Pago com o cartão");
    }
   }
}

