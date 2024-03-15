using System;
using System.Globalization;

namespace ControleDeEstoquePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            estoque.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            estoque.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            estoque.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + estoque);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            estoque.AdicionarProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + estoque);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            estoque.RemoverProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + estoque);





        }
    }
}