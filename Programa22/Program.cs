// Fecha:05/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Programa 22 Deteimnar si un numero es par o impar*/

using System;


namespace Programa4{

    class Program{

        static void Main(String[] args)
        {
            int num;
             Console.WriteLine("Ingrese numero a evaluar");
            num=Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }

        }
        }
        }