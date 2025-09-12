using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace poo6
{
    public class Estacionamento
    {
        private decimal caixa = 0.00m;
        private int limitedecarros = 10;
        private List<Carro> carros = new List<Carro>(); 

        public void EntradadeCarro ()
        {
            Carro carro = new Carro();
            Console.WriteLine("Digite a placa do carro: ");
            carro.Placa = Console.ReadLine();
            carros.Add(carro);
        }

        public void SaidadeCarro()
        {
            Console.WriteLine("Digite a placa do carro que vai sair: ");
            var id = Console.ReadLine();
            
            

        }
    }
}
