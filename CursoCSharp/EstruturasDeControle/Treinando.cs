using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class Treinando
    {
        public static void Executar()
        {
            string entrada;
            double somatorio = 0;


            Console.WriteLine("coloque sua nota:");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanho);

            for(int i = 1; i <= tamanho; i++)
            {
                Console.WriteLine("Nota do aluno");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double manda);

                somatorio += manda;
            }

            double media = tamanho; 





        } }

    }
//string entrada;

//Console.WriteLine("coloque sua entrada");
//entrada = Console.ReadLine();
//int.TryParse(entrada, out int top);


//if (top >= 10)
//{
//    Console.WriteLine("Sim deu certo");
//}
//else if (top <= 5)
//{
//    Console.WriteLine("nao deu certo");
//}
//else if (top <= 6)
//{
//    Console.WriteLine("quase deu certo");
//}
//else
//{
//    Console.WriteLine("obrigado");

//}
//Console.WriteLine("Fim");