using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provapootreino2
{
    internal class Funcionario
    {
        private string nome;
        private decimal salario;

        public decimal Salario
        {
            get { return salario; }
            set
            {
                if (value >= 0)
                {
                    salario = value;
                }
                else
                {
                    throw new ArgumentException("Valor inválido, digite um salário positivo!");
                }
            }
            
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}
