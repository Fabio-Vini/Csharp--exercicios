using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo_gasolina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double consumo;

            Console.Write("Digite a distância percorrida em Km: ");
            double km = double.Parse(Console.ReadLine());

            Console.Write("\nCombustível consumido (em litros): ");
            double gasosa = double.Parse(Console.ReadLine());

            consumo = km / gasosa;

            Console.Write("\nConsumo do veiculo: " + consumo + "Km/l");
            Console.ReadKey();
        }
    }
}
