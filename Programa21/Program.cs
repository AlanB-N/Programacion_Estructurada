// Fecha:05/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Programa 21 Verficiar si un numero es mayor  10*/

using System;
using System.Diagnostics;

namespace Programa4{

    class Program{

        static void Main(String[] args)
        {
          
            int num;  
            Console.WriteLine("Ingrese numero a evaluar");
            num=Convert.ToInt32(Console.ReadLine());
            if (num > 10)
            {
                Console.WriteLine("El numero es mayor");
            }
            else
            {
                Console.WriteLine("El numero no es mayor");
            }
                  
         }
    }
    }