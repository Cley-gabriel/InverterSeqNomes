using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3, nome4, reserva;

            Console.Write("Informe o primeiro nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Informe o segundo nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Informe o terceiro nome: ");
            nome3 = Console.ReadLine();
            Console.Write("Informe o quarto nome: ");
            nome4 = Console.ReadLine();

            // Solução para inverter os nomes
            reserva = nome1; 
            nome1 = nome4;
            nome4 = reserva;
            reserva = nome2;
            nome2 = nome3; 
            nome3 = reserva;

            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);

            Console.ReadKey();
        }
    }
}
