using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSwitch
{
    internal class Program
    {

        enum cor { Azul, Verde, Amarelo, Vermelho}
        enum opcao { Criar = 1, Deletar, Editar, Listar, Atualizar}

        static void Main(string[] args)
        {

            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            opcao opcaoselecionada = (opcao)index;

            Console.WriteLine(opcaoselecionada);

            switch (opcaoselecionada)
            {
                case opcao.Criar:
            Console.WriteLine("Você quer criar algo");
                    break;
                case opcao.Deletar:
                    Console.WriteLine("Você quer deletar algo");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada!");
                    break;
            }


            /*string cor = "Azul";

            switch(cor)
            {
                case "vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho");
                    break;

                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é Amarelo");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é Azul");
                    break;
                default:
                    Console.WriteLine("Sua cor favorita não tem");
                    break;

            }*/

            Console.ReadLine();
        }
    }
}
