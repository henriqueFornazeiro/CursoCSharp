using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 7");

            int idadeJoaozinho = 16;
            int qtdePessoas = 2;
            if(idadeJoaozinho >= 18)
            {
                Console.WriteLine("Joãozinho possui mais de 18 anos");
            }
            else
            {
                if(qtdePessoas >= 2)
                {
                    Console.WriteLine("Joãozinho não possui mais de 18 anos. Mas está acompanhado. Pode entrar");
                }
                else
                {
                    Console.Write("Joãozinho não possui mais de 18 anos");
                }
                
            }

            Console.ReadLine();
        }
    }
}
