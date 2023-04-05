using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastrar_Cliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomeFuncionarios = new string[5];
            int contador = 0;

            while (contador < nomeFuncionarios.Length)
            {
                Console.WriteLine("Digite o nome do Funcionário:");
                nomeFuncionarios[contador++] = Console.ReadLine();
                Console.Clear();
            }

            int contador2 = 0;
            while (contador2 < nomeFuncionarios.Length)
            {
                Console.WriteLine(nomeFuncionarios[contador2]);
                contador2++;
            }
            Console.ReadKey();
        }
    }
}
