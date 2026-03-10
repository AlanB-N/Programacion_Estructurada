// Fecha:05/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Estructura for y switch*/

using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace Programa28{

    class Program{

        static void Main(String[] args)
        {
            int z1=0;
            do
            {
                
                int n1=0,n2=0,s=0,opc=0,i=0;
                Console.WriteLine("Programa que muestra ek menu de opciones");
                Console.WriteLine("1.Suma de dos numeros");
                Console.WriteLine("2 Numero de saludos saludos");

                Console.WriteLine("Elige una opcion");
                opc=Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                case 1:
                Console.WriteLine("suma de dos numeros");
                Console.WriteLine("Ingresa el primero numero");
                n1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese numero 2");
                n2=Convert.ToInt32(Console.ReadLine());
                s=n1+n2;
                Console.WriteLine("El resultado de a suma es "+s);
                break;
                case 2:
                Console.WriteLine("Numero de saludos");
                Console.WriteLine("Ingrese el numero de saludos");
                n1=Convert.ToInt32(Console.ReadLine());

                    for (i = 1; i <= n1; i++)
                    {
                        Console.WriteLine("Hola desde las estrellas");
                    }
                break;
            
            default:
                Console.WriteLine("Opcion Invalida");
            break;
            }

                Console.WriteLine("Desea otra operacion? 1= si 2= no (Programa Principal)");
                z1=Convert.ToInt32(Console.ReadLine());     
            } while (z1==1);
            
        }
    }
}