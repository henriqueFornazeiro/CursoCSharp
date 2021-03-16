using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8");

            int idadeJoaozinho = 16;
            int qtdePessoas = 2;
            bool acompanhado = qtdePessoas >= 2;

            if (idadeJoaozinho >= 18 || acompanhado)
            {
                Console.WriteLine("Joãozinho pode entrar");
            }
            else
            {
                Console.Write("Joãozinho não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
