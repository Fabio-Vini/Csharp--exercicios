using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendimento_aplicacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double porcen;

            Console.Write("Digite o valor aplicado: " + "R$");
            double aplic = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor retirado: " + "R$");
            double retiro = double.Parse(Console.ReadLine());

            porcen = (retiro - aplic) * (100) / aplic;

            Console.WriteLine("O percentual ganho foi de: " + porcen + "%");
            Console.ReadKey();
        }
    }
}
