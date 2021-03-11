using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Caracteres e Textos");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine("somado e convertido: " + primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia";
            Console.WriteLine(titulo);

            string cursosProgramacao = 
@"- .Net
- Java
- Javascript";
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();
        }
    }
}
