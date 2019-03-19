using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";

            int numero;
            int maximo = 0;
            int minimo = 0;
            float promedio = 0;

            for(int i=0; i<5; i++)
            {
                Console.Write("Escriba un numero: ");
                numero = int.Parse(Console.ReadLine());
                if(i==0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else
                {
                    if (numero > maximo)
                        maximo = numero;
                    if (numero < minimo)
                        minimo = numero;
                }
                promedio += numero;
            }
            promedio = promedio / 5;
            Console.WriteLine("Maximo: {0}", maximo);
            Console.WriteLine("Minimo: {0}", minimo);
            Console.WriteLine("Promedio: {0:#,###.00}", promedio);
            Console.ReadLine();
        }
    }
}
