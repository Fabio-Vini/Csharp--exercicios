using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
           double maca;
           double result;
           double resulta;
           
           Console.WriteLine("Digite a quantia de maçãs: ");
           maca = double.Parse(Console.ReadLine());
          
          result = maca * 0.30;
          resulta = maca * 0.25;
          
          if(maca < 12)
          {
          	Console.WriteLine("O valor das maçãs é: "+result);
          }
          else
          {
          	Console.WriteLine("O valor das maçãs é:  "+resulta);
          }
           
        }
    }
}