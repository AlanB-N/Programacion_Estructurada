// Fecha:05/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Programa 24 Comprobar si un numero esta fuera de rango*/

using System;
using System.Diagnostics;

namespace Programa4{

    class Program{

        static void Main(String[] args)
        {
            int n1,n2,num;
            Console.WriteLine("Ingrese rango inferior");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese rango superior");
            n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero a evaluar");
            num=Convert.ToInt32(Console.ReadLine());

            if (num >= n1 && num <= n2)
            {
                Console.WriteLine("El numero esta en rango");
            }
            else
            {
                Console.WriteLine("El numero esta fuera de rango");
            }

        }
        }
        }