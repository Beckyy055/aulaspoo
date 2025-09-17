using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinoprovapoo1
{
    public class Caixa
    {
       

        private decimal dinheiro = 0.00m;

        public decimal Dinheiro
        {
            get { return dinheiro; }
            set
            {
                // Valida para não permitir valores negativos
                if (value >= 0)
                {
                    dinheiro = value;
                }
                else
                {
                    throw new ArgumentException("O valor do caixa não pode ser negativo.");
                }
            }
        }
        public void VerDinheiro()
        {
            Console.WriteLine($"Você tem R${dinheiro} em caixa");
        }

    }
}
