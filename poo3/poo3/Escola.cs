using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo3
{
    public class Escola
    {
        public string generica;
        List<Pessoa> pessoas = new List<Pessoa> ();
        protected int totalpessoas;
        
        public void Cadastrar (Pessoa pessoa)
        {
            pessoas.Add (pessoa);
        }

        public Pessoa GetPessoa(int indice)
        {
            return pessoas [indice];
        }

        public int TotalPessoa() => totalpessoas = pessoas.Count;

    }
}
