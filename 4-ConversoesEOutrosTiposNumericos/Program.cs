using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            double salario;
            salario = 1200.50;

            int salarioEmInt;
            salarioEmInt = (int)salario;
            Console.WriteLine("Salário convertido: "+salarioEmInt);

            long idade; //long - 64bits;
            idade = 13000000000;
            Console.WriteLine(idade);

            short qtdeProdutos; //short - 16bits;
            qtdeProdutos = 150;
            Console.WriteLine(qtdeProdutos);

            float altura;
            altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
