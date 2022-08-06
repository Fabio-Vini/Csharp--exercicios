using System;

public class Class1
{
	public Class1()
	{
	public static void Main()
        {
            double area;
            double raio;
            const double pi = 3.14;
            Console.WriteLine("Digite o valor do raio: ");
            raio = double.Parse(Console.ReadLine());
            area = pi * raio * raio;
            Console.WriteLine("A area da circunferencia é: " + area);
        }
    }
}
