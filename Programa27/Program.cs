// Fecha:05/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Programa 26 Sistema de Pensiones*/

using System;
using System.Diagnostics;

namespace Programa26{

    class Program{

        static void Main(String[] args)
        {
            int meses=0,edad=0,a=5822,b=8000,c=10000,d=1500;
            double bono=0,tot=0;
              Console.WriteLine("CUal es su edad?");
              edad=Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Meses a Pagar");
              meses=Convert.ToInt32(Console.ReadLine());
            if (edad < 50)
            {
                tot=meses*d;

            }
            else
            {
                if(edad>=50 && edad <= 65)
                {
                    tot=meses*a;
                }
                else
                {
                    if(edad>=66 && edad <= 80)
                    {
                    tot=meses*b;
                    }
                    else
                    {
                        if (edad >= 80)
                        {
                         tot=meses*c;
                         bono=tot*0.25;
                         tot=tot+bono;   
                        }
                    }
                }
            }
            Console.WriteLine("Los meses que se le  pagaron son "+meses);
            Console.WriteLine("El Bono que recibio es de "+bono);
            Console.WriteLine("El total de su pension es de "+tot);

        }
    }}