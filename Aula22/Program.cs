using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula22
{
    class Program
    {
        static void Main(string[] args)
        {

            //Treinamento - Aula22, Estrutra condicional composta, tipo int
            //Jonas Valereo - Técnico em Informática

            //Declarando a variavel tipo int

            int a = 5;

            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite um número!");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();


            //Declarando a estrutura condicional composta

            if (a > 5)
            {
                Console.WriteLine("Parabéns, é verdadeiro");
                Console.WriteLine();
                Console.WriteLine("Teste de novo!!!");
            }
            else
            {
                Console.WriteLine("Desculpe, é falso");
                Console.WriteLine();
                Console.WriteLine("Teste de novo!!!");
            }


            // saida da aplicação, console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa


        }
    }
}
