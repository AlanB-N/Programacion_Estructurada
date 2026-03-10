// Fecha:05/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Programa 23 calsifica numero como pasitivo negativo o cero*/

using System;
using System.Diagnostics;

namespace Programa4{

    class Program{

        static void Main(String[] args)
        {
            int num;
             Console.WriteLine("Ingrese numero a evaluar");
            num=Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("EL numero es cero");
                
            }
            if (num < 0)
                {
                    Console.WriteLine("El numero de negtivo");
                }
                if (num > 0)
                {
                    Console.WriteLine("El numero es psotivo");
                }
        }
        }
        }