using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 0;
            while (contador < 10){ // enquanto for verdade faça
                Console.WriteLine("Rodando o While");
                //contador = contador + 1;
                //contador += 1;
                contador++;
            }

            int contador2 = 0;
            do
            {
                Console.WriteLine("do while!");
                contador2++;
            } while (contador2 < 10);


            //Repetição foreach

            string[] palavras = { "casa", "gato", "cachorro", "moveis" };
            foreach(string palavra in palavras) {  //para casa palavra no array palavras, repita o bloco de codigo
                Console.WriteLine(palavra);
            }*/

            //Repetição for
            string[] palavras = { "casa", "gato", "cachorro", "moveis" };

            for (int contador = 0; contador < palavras.Length; contador++)
            {
                Console.WriteLine(contador);
                Console.WriteLine(palavras[contador]);
            }


            Console.ReadLine();
        }
    }
}
