// Fecha:27/01/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Programa 3 Sumar 5 numeros */

using System;
namespace programa3{
    
    class Program{

        static void Main(String[]args){

            double dec1=2.1;
            double dec2=3.5;
            double dec3=4.9;
            double dec4=5.6;
            double dec5=6.5;
            double res=0;


            res=dec1+dec2+dec3+dec4+dec5;
            Console.WriteLine("El decimal 1 es: "+dec1);
            Console.WriteLine("El decimal 2 es: "+dec2);
            Console.WriteLine("El decimal 3 es: "+dec3);
            Console.WriteLine("El decimal 4 es:"+ dec4);
            Console.WriteLine("El decimal 5 es: "+dec5);
            Console.WriteLine("El resultado es: "+res);

        }
    }
}