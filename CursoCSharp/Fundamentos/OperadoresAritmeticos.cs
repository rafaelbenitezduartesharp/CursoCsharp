using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //Preço com desconto

            var preco = 100.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var TotalComDesconto = total - total * desconto;
            Console.WriteLine("O preço final é {0}", TotalComDesconto);


            //IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}.");

            //Numeros Par/Impar 
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem o resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem o resto {1}", impar, par % 2);

        }
    }
}
