using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeAPSqt02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* QUESTÃO 01 */

            Aluno a1 = new Aluno("Felipe Alves da Silva", "12018110983"); // Instanciamento recebendo Nome completo e No. de matríula
                a1.setCpf(05475398356);
            Aluno a2 = new Aluno("Antônio Numes de Limeira", 48948705334); // Instanciamento recebendo Nome completo e CPF
            a2.setMatricula("12018115478");

            // Métodos 'Imprimir'
            Console.WriteLine("Dados do 1o aluno: ");
            Console.WriteLine();
            Console.WriteLine("Nome: " + a1.imprimirNomeCompleto());
            Console.WriteLine("No. de Matrícula: " + a1.imprimirMatricula());
            Console.WriteLine("No. CPF: " + a1.imprimirCpf());
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine();
            Console.WriteLine("Dados do 2o aluno: ");
            Console.WriteLine();
            Console.WriteLine("Nome: " + a2.imprimirNomeCompleto());
            Console.WriteLine("No. de Matrícula: " + a2.imprimirMatricula());
            Console.WriteLine("No. CPF: " + a2.imprimirCpf());
            Console.ReadKey();
        }
    }
}
