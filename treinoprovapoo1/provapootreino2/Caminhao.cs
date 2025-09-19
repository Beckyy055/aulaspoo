using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provapootreino2
{
    public class Caminhao : Veiculo, IPagavel
    {

        private int pedagio;

        public Caminhao(string placa, string cor) : base(placa, cor)
        {
        }

        decimal IPagavel.PagarPedagio()
        {

            pedagio = 20;

            return pedagio;
        }

        public int Pedagio
        {
            get { return pedagio; }
            set { pedagio = value; }
        }

        public override void LigarMotor()
        {
            Console.WriteLine("Ligando o motor do caminhão");
        }


    }
}
