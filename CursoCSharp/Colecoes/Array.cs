﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
     class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Rafa";
            alunos[1] = "Rafael";
            alunos[2] = "Benitez";
            alunos[3] = "Duarte";
            alunos[4] = "Geise";

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach(var nota in  notas)
            {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            String palavra = new string(letras);

            Console.WriteLine(palavra);
           
        }
    }
}
