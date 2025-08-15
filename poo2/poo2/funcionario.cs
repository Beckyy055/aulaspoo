using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo2
{
    internal class funcionario
    {
        private string cargo;
        private string setor;
        private List<string> beneficios = new();
        private string registro;
        private float salario;

        public Funcionario(string cargo, string setor, string registro, float salario, List<string> beneficios)
        {
            this.cargo = cargo;
            this.setor = setor;
            this.registro = registro;
            this.salario = salario;
            this.beneficios = beneficios;
        }

        public string Cargo { get { return cargo; } set { cargo = value; } }
        public string Setor { get { return setor; } set { setor = value; } }
        public string Registro { get { return registro; } set { registro = value; } }
        public float Salario { get { return salario; } set { salario = value; } }
        public List<string> Beneficios { get { return beneficios; } set { beneficios = value; } }
    }
    
}

