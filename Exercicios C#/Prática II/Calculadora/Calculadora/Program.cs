using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double calc;
            
            inicio:

            Console.Write("Digite um valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Digite outro valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.Write("Digite um simbolo de operação para calcular:");
            Console.Write("\n+ - * /: ");
            char op = char.Parse(Console.ReadLine());

            if (op == '+')
            {
                calc = v1 + v2;

                Console.Write("\nResultado: " + calc);
                Console.WriteLine("");
                goto inicio;
            }
            else if (op == '-')
            {
                calc = v1 - v2;

                Console.Write("\nResultado: " + calc);
                Console.WriteLine("");
                goto inicio;
            }
            else if (op == '*')
            {
                calc = v1 * v2;

                Console.Write("\nResultado: " + calc);
                Console.WriteLine("");
                goto inicio;
            }
            else if (op == '/')
            {
                calc = v1 / v2;

                Console.Write("\nResultado: " + calc);
                Console.WriteLine("");
                goto inicio;
            }
            else
            {
                Console.Write("Opção inválida!");
                goto inicio;
                Console.ReadKey();
            }
        }
    }
}
