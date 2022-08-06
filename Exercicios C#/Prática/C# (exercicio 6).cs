using System;

public class Class1
{
	public Class1()
    {
        public static void Main()
        {
            int A;
            int B;
            int res;
            Console.WriteLine("Digite o valor de A");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            B = int.Parse(Console.ReadLine());
            res = A + B;
            Console.WriteLine("A soma é: " + res);
            res = A - B;
            Console.WriteLine("A subtração é:" + res);
            res = A * B;
            Console.WriteLine("A multiplicação é: " + res);
            res = A / B;
            Console.WriteLine("A divisão é: " + res);
        }
    }
}


