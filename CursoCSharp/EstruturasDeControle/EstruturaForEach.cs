using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
     class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "rafael";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Rafael" };


            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
