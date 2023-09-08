﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
     class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var item in pilha)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}
