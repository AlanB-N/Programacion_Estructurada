// Fecha:03/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Programa 12 pide al usuario un numero de punto flotante, multitplicalo por dos y 
muestra el resutltado*/

using System;

namespace Programa4{

    class Program{

        static void Main(String[] args)
        {
          
            double n1,res;

            Console.WriteLine("Ingresa numero decimal");
            n1=Convert.ToDouble(Console.ReadLine());
            res=n1*2;
            Console.WriteLine(res);
        }
    }
    }