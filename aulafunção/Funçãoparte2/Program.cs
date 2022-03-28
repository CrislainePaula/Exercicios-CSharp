using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funçãoparte2
{
    internal class Program //aula retornar função
    {
        static void Main(string[] args)
        {
            /*int soma1 = Somar(2, 4, 5);
            int soma2 = Somar(10, 20, 8);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.ReadLine();
        }

        static int Somar(int a, int b, int c)
        {
            int resultadofinal = a + b + c;
            return resultadofinal;
        }*/

            //Aula Array - sempre definir o tipo


        string[] produtos = new string[5] {"Carro",
            "Moto",
            "Avião",
            "Trem",
            "Navio"
        };


            int[] valores = { 40, 50, 60, 70, 20 };//maneira simples de criar array



            produtos[4] = "Navio Fantasma"; //atualizar o valor
            Console.WriteLine(produtos[4]);

            Console.ReadLine();

        }
    }
}
