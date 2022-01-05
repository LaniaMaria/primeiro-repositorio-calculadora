using System;
using System.Collections.Generic;



namespace Calculadora
{
    public class Programs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 - Somar, 2 - Subtrair, 3 - Dividir, 4 - Multiplicar");
            int calc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(calc);
            int um, dois, zero;
            

            switch (calc)
            {
                case 1:
                    Console.WriteLine("Digite primeiro valor: ");
                    um = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite segundo valor: ");
                    dois = Convert.ToInt32(Console.ReadLine());

                    zero = um + dois;
                    Console.WriteLine("Valor da Soma = {0}", zero);
                    break;

                case 2:
                    Console.WriteLine("Digite primeiro valor: ");
                    um = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite segundo valor: ");
                    dois = Convert.ToInt32(Console.ReadLine());

                    zero = um - dois;
                    Console.WriteLine("Valor da Subtração = {0}", zero);
                    break;

                case 3:
                    Console.WriteLine("Digite primeiro valor: ");
                    um = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite segundo valor: ");
                    dois = Convert.ToInt32(Console.ReadLine());

                    zero = um / dois;
                    Console.WriteLine("Valor da Divisão = {0}", zero);
                    break;

                case 4:
                    Console.WriteLine("Digite primeiro valor: ");
                    um = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite segundo valor: ");
                    dois = Convert.ToInt32(Console.ReadLine());

                    zero = um * dois;
                    Console.WriteLine("Valor da Multiplicação = {0}", zero);
                    break;

            }

        }


    }

}
