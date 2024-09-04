using System;
namespace Day32
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();
            //UPCAST
            pessoa = new PessoaFisica();
            pessoa = new PessoaJuridica();
            //DownCast
            var pessoa2 = new Pessoa();
            var pessoaFisica = new PessoaFisica();
            pessoa2 = pessoaFisica;
            pessoaFisica = (PessoaFisica)pessoa2;
        }   
    }
    public class Pessoa
    {
        public string Nome { get; set; }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
    }

    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
    }
}
