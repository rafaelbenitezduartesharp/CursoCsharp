using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {


            Console.WriteLine("FilhoReconhecido..");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamília);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
