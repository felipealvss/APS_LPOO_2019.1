using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeAPSqt10
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto m1 = null;
            m1 = new Moto("Shineray", "Motocicleta", "Vermelha", 1, true);

            Console.WriteLine();
            Console.WriteLine("Descrições da moto:");
            Console.WriteLine("= Marca: " + m1.imprimirMarca());
            Console.WriteLine("= Modelo: " + m1.imprimirModelo());
            Console.WriteLine("= Cor: " + m1.imprimirCor());
            Console.WriteLine("= Marcha: " + m1.imprimirMarcha());
            Console.WriteLine("= Ligada = " + m1.imprimirLigada());
            Console.WriteLine();

            m1.marchaAcima(); // Aumento de marcha! x1
            m1.marchaAcima(); // Aumento de marcha! x2
            Console.WriteLine("Aumento de marcha!");
            Console.WriteLine("Marcha atual: " + m1.imprimirMarcha());
            Console.WriteLine();

            m1.marchaAbaixo(); // Redução de marcha! x1
            Console.WriteLine("Redução de marcha!");
            Console.WriteLine("Marcha atual: " + m1.imprimirMarcha());
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
