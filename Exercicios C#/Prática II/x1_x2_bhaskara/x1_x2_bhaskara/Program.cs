using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x1_x2_bhaskara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bhaska, x1, x2;

            Console.Write("Digite o valor de a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            double c = double.Parse(Console.ReadLine());

            bhaska = (Math.Pow(b, 2) - 4 * a * c);

            if (bhaska >= 0)
            {
                x1 = (-b + Convert.ToSingle(Math.Sqrt(bhaska))) / (2 * a);

                x2 = (-b - Convert.ToSingle(Math.Sqrt(bhaska))) / (2 * a);

                Console.Write("Delta é igual a: " + bhaska + "\nX1 é igual a: " + x1 + "\nX2 é igual a: " + x2);
            }
            else
            {
                Console.WriteLine("Resultado negativo! Sem solução");
            }
            Console.ReadKey();
        }
    }
}
