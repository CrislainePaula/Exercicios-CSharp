using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulacondição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Estrutura condicional AEPENAS UMA CONDIÇÃO


            int a = 10;
            int b = 20;
            int c = 2;

            if (a > b) // se
            {
                Console.WriteLine("É verdade");
            }
            else if (a > c){
                Console.WriteLine("É verdade sim");
            }

            else // se não
            {
                Console.WriteLine("É mentira");
            }*/



            //OPERADORES LOGICOS 
            //(&& e ou AND)
            /*cond && cond2 => v com v é verdadeiro
             v com f é falso / f com f é falso*/

            //(|| ou/or) 
            //v com f é verdeiro / v com v é verdadeiro
            // f com f é falso
            //se uma condição for verdade então ela é verdadeira


            /*int a = 10;
            int b = 20;
            int c = 200;


            if (a < b || a > c)
            {
                Console.WriteLine("É verdade!");
            }
            else if (a > c)
            {
                Console.WriteLine("If else");
            }
            else
            {
                Console.WriteLine("Não é verdade!");
            }

            Console.ReadLine();*/


            //Pequeno programa que verifica se uma pessoa é criança ou adulto pela idade 


            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());
           

            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é criança!");
            }
            else if(idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Você é adolescente!");
            }
            else if(idade >= 19 && idade <= 60)
            {
                Console.WriteLine("Você é adulto!");
            }
            else
            {
                Console.WriteLine("Você é idoso!");
            }

            Console.ReadLine();
        }
    }
}
