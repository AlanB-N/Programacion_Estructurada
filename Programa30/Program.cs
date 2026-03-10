// Fecha:12/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Estructura for 1*/

using System;
using System.Reflection.Emit;


namespace Programa30{

    class Program{

        static void Main(String[] args)
        {
            int edad=0,i=0, opc=0;
            do
            {
                 Console.WriteLine("Que edad tienes?");
            edad=Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                for (i = 1; i <= edad; i++)
                {
                    Console.WriteLine("Mira un gato Jet Pack");
                }
            }
            Console.WriteLine("Desea otra operacion? 1= si 2= no");
            opc=Convert.ToInt32(Console.ReadLine());
            } while (opc==1);
           
        }
    }
}