using System;

namespace Aula22
{
    class Program
    {
        static void Main(string[] args)

        {

                //FOI
            Console.WriteLine("Digite um valor a ser convertido:");
            float x = float.Parse(Console.ReadLine());


            Console.WriteLine("EM DOLAR PRA REAL:");
            Console.WriteLine( Conversor.DolarParaReais(x) );
            Console.WriteLine("EM REAL PRA DOLAR:");
            Console.WriteLine( Conversor.RealParaDolar(x) );
            Console.WriteLine("EM EURO PRA REAL");
            Console.WriteLine( Conversor.EuroParaReais(x) );
            Console.WriteLine("EM REAL PARA EURO");
            Console.WriteLine( Conversor.RealParaEuro(x) );
        }
    }
}
