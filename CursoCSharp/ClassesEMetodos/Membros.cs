using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
     class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Rafael";
            sicrano.Idade = 21;

            sicrano.ApresentarNoConsole();

            var Fulano = new Pessoa();
            Fulano.Nome = "Benitez";
            Fulano.Idade = 22;

            var apresentacaoDoFulano = Fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);


         
        }
    }
}
