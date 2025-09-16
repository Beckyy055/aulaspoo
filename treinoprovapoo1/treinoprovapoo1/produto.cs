using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinoprovapoo1
{
    internal class Produto : Caixa
    {
        private string nome;
        private decimal preco;
        private int quantidade;
        List<Produto> produtos = new List<Produto>();
        private string nprod;
        Produto produto = new Produto();
        Caixa caixa = new Caixa();

        public void Cadastrar()
        {
            Console.WriteLine("Digite o nome do produto: ");
            
            produtos.Add(produto);
            produto.nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto: ");
            produto.preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de produtos: ");
            produto.quantidade = int.Parse(Console.ReadLine());
        }

        public void Adicionar()
        {
            Console.WriteLine("Qual o nome do produto que você deseja adicionar? ");
            nprod = Console.ReadLine();
            Produto produtoEncontrado = produtos.Find(p => p.nome == nprod);
            if (produtoEncontrado != null)
            {
                Console.WriteLine("Digite a quantidade que você deseja adicionar: ");
                produto.quantidade = produto.quantidade + int.Parse(Console.ReadLine());
            }
        }

        public void Vender()
        {
            Console.WriteLine("Qual produto você vai vender? ");
            nprod = Console.ReadLine();
            Produto produtoEncontrado = produtos.Find(p => p.nome == nprod);
            if (produtoEncontrado != null)
            {
                produto.quantidade = produto.quantidade - 1;
                caixa.Dinheiro += produtoEncontrado.preco;
                Console.WriteLine("Produto vendido com sucesso!");
            }
        }


    }
}
