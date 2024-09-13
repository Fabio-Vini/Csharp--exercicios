using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_ensino_medio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media = 0, soma = 0;

            Console.WriteLine("Agora , digite as quatro notas:");

            for (int i = 1; i < 5; i++)
            {
                Console.Write("Digite a nota " + i + ":");
                double nota = 0;

                double.TryParse(Console.ReadLine(), out nota);
                //TryParse vai receber o que for digitado e OUT é o comando que diz
                //para onde vai isso que foi digitado, nesse caso, o que você digitar
                //vai para a variável 'nota'

                soma += nota;
            }
            media = soma / 4;
            Console.WriteLine("A média de suas notas é: " + media);
            Console.ReadKey();
        }
    }
}
