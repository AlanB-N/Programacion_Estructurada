// Fecha:03/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Programa 12 pide al usuario que escriba su nombre por consola, obten el total 
de caracteres del nombre sumale un numero punto flotante y 
muestra el resultado*/

using System;

namespace Programa4{

    class Program{

        static void Main(String[] args)
        {
            String nombre;
            int caracteres;
            double res;
            Console.WriteLine("Escriba su nombre");
            nombre=Console.ReadLine();
            caracteres=nombre.Length;
            res= caracteres+3.14;
            Console.WriteLine(res);
        }
    }
    }