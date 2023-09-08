using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos 
        public string InfoPublica = "Tenho um Instragram!";

        // herança
        protected string CorDoOhos = "Verde";

        // Mesmo projeto (assembly)
        internal ulong NumeroCelular = 515151512030;

        // herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // mesma class ou herança no mesmo projeto (c# >= 7.2)
        private protected string SegredoFamília = "Bla bla";

        // private é o Padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("Subcelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamília);
            Console.WriteLine(UsaMuitoPhotoshop);
        }

    }
}
