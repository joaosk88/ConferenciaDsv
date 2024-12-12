using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenciaDsv.Models
{
    internal class Cubagem
    {
        // Método para calcular o volume de uma única caixa
        public double CalcularVolumeCaixa(double altura, double largura, double profundidade)
        {
            return altura * largura * profundidade;
        }

        // Método para calcular o volume total de múltiplas caixas
        public double CalcularVolumeTotal(List<(double Altura, double Largura, double Profundidade)> caixas)
        {
            double volumeTotal = 0;

            foreach (var caixa in caixas)
            {
                double volumeCaixa = CalcularVolumeCaixa(caixa.Altura, caixa.Largura, caixa.Profundidade);
                volumeTotal += volumeCaixa;
            }

            return volumeTotal;
        }
    }
}
