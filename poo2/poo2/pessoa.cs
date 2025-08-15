using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo2
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private string cpf;
        private cor = new Cor;
        private genero = new Genero;

        public Pessoa(string nome, int idade, string cpf, Cor cor, Genero genero)
        {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.cor = cor;
            this.genero = genero;
        }
        public string Nome { get { return nome; }, set { nome = value; } }
        public int Idade { get { return idade; } set { idade = value; } }
        public string Cpf { get { return cpf; } set { cpf = value; } }
        public Cor cor { get { return cor; } set { cor = value; } }
        public Genero genero { get { return genero; } set { genero = value; } }

    }

    public enum Cor
    {
        Branco, Negro, Indígena, Pardo, Asiático, Indígena, Outro
    }
    public enum Genero
    {
        mulher cis, mulher trans, homem cis, homem trans, não-binário, agênero, gênero fluido, outro
    }
}
