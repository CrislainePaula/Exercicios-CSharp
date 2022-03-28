using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulafunção
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Gerarpreco(20);
            /*Pandoro(); //chamar uma função

            Gerarpreco(60, "Calça");
            Gerarpreco(800, "Celular");
            Console.ReadLine();
        }

        static void Pandoro() //função
        {

            Console.WriteLine("Esse sistema é show de bola");
            Console.WriteLine("Pandoro lindo");
        }

        static void Gerarpreco(int preco, string nome)
        {
            Console.WriteLine(preco);
            Console.WriteLine("Nome do produto: " + nome);

        }
        */


            Console.ReadLine();
        }

        static void Gerarpreco(int preco)
        {
            int precoABS = Math.Abs(preco); //converte numero negativo em positivo

            int valorfinal = preco + (2 * preco);
            Console.WriteLine("Valor final: " + valorfinal);
        }

        

    }
}
