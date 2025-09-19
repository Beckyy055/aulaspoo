using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provapootreino2
{
    public class Carro : Veiculo, IPagavel
    {
        private int pedagio;

        public Carro(string placa, string cor) : base(placa, cor)
        {
        }

        decimal IPagavel.PagarPedagio()
        {
            pedagio = 5;
            return pedagio;
        }

        public int PedagioC
        {
            get { return pedagio; }
            set { pedagio= value; }
        }

        public override void LigarMotor()
        {
            Console.WriteLine("Ligando o motor do carro");
        }

    }
}
