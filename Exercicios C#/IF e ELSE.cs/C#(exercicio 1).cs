using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        inicio:
            Console.WriteLine();
            Console.Write("Digite o primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            if (v1 > v2)
            {
                Console.WriteLine("O primeiro valor é maior");
            }
            else if(v1 == v2)
            {
                Console.WriteLine("Não digite valores iguais!");
                goto inicio;
            }
            else
            {
                Console.WriteLine("O segundo  valor é maior");
            }
            Console.ReadKey();
        }
    }
}
