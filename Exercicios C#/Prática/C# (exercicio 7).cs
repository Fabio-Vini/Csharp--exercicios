using System;

public class Class1
{
	public Class1()
    { 
        public static void Main()
        {
            double prestação;
            double valor;
            double taxa;
            double tempo;
            Console.Write("Digite o valor da prestação");
            valor = double.Parse(Console.ReadLine());
            Console.Write("Digite a taxa de juros");
            taxa = double.Parse(Console.ReadLine());
            Console.Write("Digite a qtd de dias de atraso");
            tempo = double.Parse(Console.ReadLine());
            prestação = valor + (valor * (taxa / 100) * tempo);
            Console.Write("O valor da prestação é: " + prestação);
        }
    }
}


