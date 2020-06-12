using System;

namespace construtorCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto sapato = new Produto();
            sapato.Nome = "Vizzano";
            
            Produto chinelo = new Produto(45);
            System.Console.WriteLine(chinelo.Codigo);

            Produto camisa = new Produto(34, "Nike", "Azul", 230);
            System.Console.WriteLine($"{camisa.Codigo}, {camisa.Nome}, {camisa.Descricao}, {camisa.Estoque}");



        }
    }
}
