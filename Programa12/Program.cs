// Fecha:03/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Programa 12 pide al usuario 2 numeros, sumalos y muestra el resultado*/

using System;

namespace Programa4{

    class Program{

        static void Main(String[] args)
        {
            int n1,n2,res;
            Console.WriteLine("Escriba 2 numeros");
            Console.WriteLine("Escriba numero 1");
            n1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba numero 2");
            n2= Convert.ToInt32(Console.ReadLine());
            res=n1+n2;
            Console.WriteLine("El resultado es "+res);
        }
    }
    }

