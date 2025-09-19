using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace provapootreino2
{
    public class Circulo : Forma
    {

        private double raio;

        public override void CalcularArea()
        {
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"a área do seu círculo é de {area, 2}");
        }

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

    }
}
