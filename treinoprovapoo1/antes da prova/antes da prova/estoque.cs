using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using treinoprovapoo1;

namespace treinoprovapoo1
{
    public class Estoque
    {
        // A lista de produtos agora deve ser privada
        private List<Produto> produtos = new List<Produto>();
        private Caixa caixa = new Caixa();

        // 1. Método para cadastrar um novo produto
        public void Cadastrar()
        {
            Console.WriteLine("\n--- Cadastrar Produto ---");
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            // Verifica se o produto já existe
            if (produtos.Find(p => p.nome.Equals(nome, StringComparison.OrdinalIgnoreCase)) != null)
            {
                Console.WriteLine("Erro: Produto já existe no estoque.");
                return;
            }

            Console.Write("Digite o preço do produto: ");
            decimal preco = decimal.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de produtos: ");
            int quantidade = int.Parse(Console.ReadLine());

            // Cria e adiciona o novo produto à lista
            Produto novoProduto = new Produto(nome, preco, quantidade);
            produtos.Add(novoProduto);
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        // 2. Método para adicionar produtos ao estoque
        public void Adicionar()
        {
            Console.WriteLine("\n--- Adicionar ao Estoque ---");
            Console.Write("Qual o nome do produto que você deseja adicionar? ");
            string nome = Console.ReadLine();

            Produto produtoEncontrado = produtos.Find(p => p.nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (produtoEncontrado != null)
            {
                Console.Write("Digite a quantidade que você deseja adicionar: ");
                int quantidadeAdicionar = int.Parse(Console.ReadLine());
                produtoEncontrado.quantidade += quantidadeAdicionar;
                Console.WriteLine($"Quantidade atualizada. Novo estoque: {produtoEncontrado.quantidade}");
            }
            else
            {
                Console.WriteLine("Erro: Produto não encontrado.");
            }
        }

        // 3. Método para vender um produto
        public void Vender()
        {
            Console.WriteLine("\n--- Vender Produto ---");
            Console.Write("Qual produto você vai vender? ");
            string nome = Console.ReadLine();

            Produto produtoEncontrado = produtos.Find(p => p.nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (produtoEncontrado != null)
            {
                if (produtoEncontrado.quantidade > 0)
                {
                    produtoEncontrado.quantidade--; // Decrementa a quantidade
                    caixa.Dinheiro += produtoEncontrado.preco; // Adiciona o valor da venda ao caixa
                    Console.WriteLine("Produto vendido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Erro: Produto fora de estoque.");
                }
            }
            else
            {
                Console.WriteLine("Erro: Produto não encontrado.");
            }
        }

        // 4. Método para ver o status do estoque (que você queria)
        public void Status()
        {
            Console.WriteLine("\n--- Status do Estoque ---");
            if (produtos.Count == 0)
            {
                Console.WriteLine("O estoque está vazio.");
                return;
            }
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"Nome: {produto.nome}, Quantidade: {produto.quantidade}, Preço: {produto.preco:C}");
            }
        }

        // E um método para mostrar o saldo do caixa
        public void VerDinheiro()
        {
            Console.WriteLine($"\n--- Saldo do Caixa ---");
            Console.WriteLine($"Saldo atual: {caixa.Dinheiro:C}");
        }

    }
}
