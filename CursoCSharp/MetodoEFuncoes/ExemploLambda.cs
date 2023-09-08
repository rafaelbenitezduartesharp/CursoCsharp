using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
     class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com c#");
            };

            algoNoConsole();

            Func<int> JogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(JogarDado());

            Func<int, string> coversorHex = numero =>  numero.ToString("X");
            Console.WriteLine(coversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            Console.WriteLine(formatarData(1,1,2019));

        }
    }
}
