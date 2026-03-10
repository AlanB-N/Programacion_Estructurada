// Fecha:05/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Programa 24 utiliza el operador ternario en condiciones*/

using System;
using System.Diagnostics;

namespace Programa4{

    class Program{

        static void Main(String[] args)
        {
            
            int num;
             Console.WriteLine("Ingrese numero a evaluar");
            num=Convert.ToInt32(Console.ReadLine());
            String r=(num%2==0)?"Par":"Impar";
            Console.WriteLine(r);
        }
        }
        }