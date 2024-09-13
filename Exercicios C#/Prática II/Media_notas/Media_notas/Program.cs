using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float media;

            Console.Write("Digite a nota do 1º bimestre: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a nota do 2º bimestre: ");
            float n2 = float.Parse(Console.ReadLine());

            media = (n1 + n2) / 2;

            Console.Write("A média de sua nota é: " + media);

            Console.ReadKey();
        }
    }
}
