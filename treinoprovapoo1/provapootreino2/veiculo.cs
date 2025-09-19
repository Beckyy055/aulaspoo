using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace provapootreino2
{
    public abstract class Veiculo : IPagavel
    {
        private string placa;
        private string cor;

        public Veiculo(string placa, string cor)
        {
            this.placa = placa;
            this.cor = cor;
        }

        decimal IPagavel.PagarPedagio()
        {
            int pedagio = 5;
            return pedagio;
        }

        public virtual void LigarMotor()
        {
            Console.WriteLine("Ligando o motor");
        }
    }
}
