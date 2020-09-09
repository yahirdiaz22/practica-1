using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionConsolaC_08092020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear o declarar las variables a utilizar
            int n1, n2, s;

            //Preguntar el valor del primer numero
            Console.Write("N1: ");
            try
            {
                n1 = Int32.Parse(Console.ReadLine());


                //Preguntar el valor del segundo numero
                Console.Write("N2: ");
                n2 = Int32.Parse(Console.ReadLine());

            }
            catch (Exception x)
            {
                Console.WriteLine("Dato invalido!!!  " + x.Message);
                Console.ReadKey();
                return;
            }
            //Sumarlos
            s = n1 + n2;
            //Mostrar el resultado

            Console.Write("A suma de " + n1 + " + " + n2 + " = " + s);
            Console.ReadKey();
        }
    }
}
