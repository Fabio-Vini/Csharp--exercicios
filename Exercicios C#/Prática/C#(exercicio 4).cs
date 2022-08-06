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
        /*Escreva um programa para ler 2 valores
         (considere	que não serão informados valores iguais)	
         e escrever o maior deles*/

            inicio:
            Console.WriteLine("");
            Console.WriteLine("Digite 2 valores");

            Console.Write("1º valor: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("2º valor: ");
            double y = double.Parse(Console.ReadLine());

            if(x == y)
            {
                Console.WriteLine("Não digite valores iguais!");
                goto inicio;
            }
            else if(x > y)
            {
                Console.WriteLine("O 1º valor é maior");
            }
            else
            {
                Console.WriteLine("O 2º valor é maior");
            }
            Console.ReadKey();
        }
    }
}
