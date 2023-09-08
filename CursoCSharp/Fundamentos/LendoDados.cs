using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qaul é seu Nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qaul é sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qaul é seu salario?");
            double salario = double.Parse(Console.ReadLine());
            CultureInfo invariantCulture = CultureInfo.InvariantCulture; ;

            Console.WriteLine($"Seu nome é:{nome} e sua idade é {idade} esta ganhando bem R${salario}");
        }
    }
}
