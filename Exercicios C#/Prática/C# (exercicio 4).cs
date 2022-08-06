using System;

public class Class1
{
	public Class1()
	{
        public static void Main()
        {
            double aulas;
            double valor;
            double desconto;
            double salario;
            Console.WriteLine("Digite a quantidade de aulas dadas");
            aulas = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora aula");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual de desconto do INSS");
            desconto = double.Parse(Console.ReadLine());
            salario = (aulas * valor) * (1 - desconto / 100);
            Console.WriteLine("Seu salario é: " + salario);
        }

    }
}



