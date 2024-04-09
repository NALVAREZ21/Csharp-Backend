using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp227
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero_uno, numero_dos, resultado;
            Console.Write("Ingrese el primer valor: ");
            numero_uno = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el primer valor: ");
            numero_dos = int.Parse(Console.ReadLine());

            resultado = numero_uno + numero_dos;

            
            Console.WriteLine("El calculo es: " + resultado);
            Console.ReadKey();
         }

    }
}