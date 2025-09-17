using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinoprovapoo1
{
    public class Produto
    {

        public string nome { get; set; }
        public decimal preco { get; set; }
        public int quantidade { get; set; }

        // Construtor
        // Ele recebe os parâmetros e os atribui às propriedades
        public Produto(string nome, decimal preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }
    }
}
