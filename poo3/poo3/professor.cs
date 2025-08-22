using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo3
{
    internal class Professor: Pessoa
    {
        protected string materia;
        protected float salario;
        protected List<string> beneficios = new();

        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        public float Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public void Beneficios (string Beneficios)
        {
            beneficios.Add(Beneficios);
        }
    }

 


}
