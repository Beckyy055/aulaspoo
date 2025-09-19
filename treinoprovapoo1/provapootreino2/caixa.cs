using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provapootreino2
{
    internal class Caixa
    {
        // Campo privado encapsulado
        private decimal _totalArrecadado = 0.00m;

        public void ProcessarPagamento(IPagavel veiculo)
        {
            // O polimorfismo acontece aqui! O método PagarPedagio()
            // se comporta de maneira diferente para CarroDePasseio e Caminhao.
            decimal valorPedagio = veiculo.PagarPedagio();

            // Acumula o valor
            _totalArrecadado += valorPedagio;

            Console.WriteLine($"Veículo pagou pedágio de {valorPedagio:C}.");
        }

        // Método público para exibir o total
        public void ExibirTotalArrecadado()
        {
            Console.WriteLine($"\nTotal arrecadado no pedágio: {_totalArrecadado:C}");
        }


    }
}
