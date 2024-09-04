using System;
namespace Day33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var pessoaA = new Pessoa(9, "Ronaldo Fenomeno");
            var pessoaB = new Pessoa(43,"Talles Magno");

            Console.WriteLine(pessoaA == pessoaB); //vai retornar false, pq só compara o local armazenado na memoria.
            Console.WriteLine(pessoaA.Equals(pessoaB)); //Vai retornar false, mas dessa vez é pq ele comparou o conteudo dos itens.
        }
    }

    public class Pessoa : IEquatable<Pessoa>
    {
        public Pessoa(int camisa, string nome)
        {   Camisa = camisa;
            Nome = nome;
        }
        public int Camisa {get; set; }
        public string Nome { get; set; }

        public bool Equals (Pessoa other)
        {
            return Camisa == other.Camisa && Nome == other.Nome;
        }
    }
}
