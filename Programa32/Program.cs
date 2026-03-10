// Fecha:12/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Estructura switch 2*/

using System;
using System.Diagnostics.CodeAnalysis;


namespace Programa32{

    class Program{

        static void Main(String[] args)
        {
            int opc,i=0,op=0;
            double km,C,F,cm,num,lit,gal;
            do
            {
                 Console.WriteLine("Menu de Opciones");
            Console.WriteLine("Seleccione operacion a trabajar");
            Console.WriteLine("1-Convertir KM a CM");
            Console.WriteLine("2-Convertir C° a F°");
            Console.WriteLine("3- Convertir Litros a Galones");
            Console.WriteLine("4-Factorial");
            Console.WriteLine("Elija una opcion");
            opc=Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                Console.WriteLine("Ingrese los KM a convertir");
                km=Convert.ToDouble(Console.ReadLine());
                cm=km*100000;
                Console.WriteLine("Los centimetros de "+km+" son "+cm);
                break;

                case 2:
                Console.WriteLine("Ingrese grados centigrados");
                C=Convert.ToDouble(Console.ReadLine());
                F=(1.8*C)+32;
                Console.WriteLine("Los grados Farenheith son "+F);
                break;

                case 3:
                Console.WriteLine("Ingrese litros");
                lit=Convert.ToDouble(Console.ReadLine());
                gal=lit/3.78541;
                Console.WriteLine("Los galones son "+gal);
                break;

                case 4:
                Console.WriteLine("Ingrese numero a evaluar");
                num=Convert.ToInt32(Console.ReadLine());
                double suma=num;
                    for (i = 1; i < num; i++)
                    {
                        suma=suma*i;
                    }
                    Console.WriteLine(suma);
                break;    
            

                
                default:
                Console.WriteLine("Ingrese opcion valida");
                break;
            }

                Console.WriteLine("Desea otra operacion? 1= si 2= no");
                op=Convert.ToInt32(Console.ReadLine());    
            } while (op==1);

            
        }
    }
}