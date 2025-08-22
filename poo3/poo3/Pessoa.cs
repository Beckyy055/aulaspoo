using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo3
{
    public class Pessoa
    {
        protected string nome;
        protected string idade;
        protected Genero genero;
        protected string cpf;
        protected Raça raça;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }

        }
        public string Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public Genero Genero
        {
            get { return Genero; }
            set { Genero = value; }
        }
        public Raça Raça
        {
            get { return Raça; }
            set { Raça = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

    }

    public enum Genero
    {
        mulhercis, mulhertrans, homemcis, homemtrans, generofluido, agenero, naobinario, outro
    }
    public enum Raça
    {
        branco, preto, pardo, indigena, asiatico, outro
    }
}
