using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provapootreino2
{
    public class Retangulo : Forma
    {
        private int largura;
        private int altura;


        public override void CalcularArea()
        {
            int area = altura * largura;
            Console.WriteLine($"a área do seu retângulo é de {area}");
        }

        public int Largura
        {
            get { return largura; }
            set { largura = value; }
        }

        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }
    }
}
