using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;

        string nome;
        public string Nome
        {
            get
            {
                return "opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }
        //Propriedade autoimplementada
        public double Preco { get; set; }

        //Somente leitura
        //1 Opção
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco);//Lambda =>

            //2 Opção
            //get
            //{
            //    return Preco - (desconto * Preco);
            //}
        }
        public CarroOpcional() //Construtor
        {

        }

        // Construtor Parametro
        public CarroOpcional(string nome, double preco)
        {
            this.nome = nome;
            Preco = preco;
        }

    }

        class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);

            //op1.PrecoDesconto = 3000;

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Eletrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}
