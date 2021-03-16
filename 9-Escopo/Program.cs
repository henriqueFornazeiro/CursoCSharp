using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9");

            int idadeJoaozinho = 16;
            int qtdePessoas = 2;
            bool acompanhado = qtdePessoas >= 2;
            string msgAdicional;

            if (acompanhado)
            {
                msgAdicional = "Joãozinho está acompanhado";
            }
            else
            {
                msgAdicional = "Joãozinho não está acompanhado";
            }
            
            if (idadeJoaozinho >= 18 && acompanhado)
            {
                Console.WriteLine("Joãozinho pode entrar");
                Console.WriteLine(msgAdicional);
            }
            else
            {
                Console.Write("Joãozinho não pode entrar");
                Console.WriteLine(msgAdicional);
            }

            Console.ReadLine();
        }
    }
}
