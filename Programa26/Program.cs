// Fecha:05/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Programa 26 Descuentos de tienda*/

using System;
using System.Diagnostics;

namespace Programa26{

    class Program{

        static void Main(String[] args)
        {
            double tot=0, monto=0, des=0;
            Console.WriteLine("Cuanto Compro?");
            monto=Convert.ToDouble(Console.ReadLine());
            if (monto <= 1000)
            {
                Console.WriteLine("No aplica descuento");
                tot=monto;

            }
            else
            {
                if(monto>=1000 && monto < 3000)
                {
                    des=monto*0.20;
                    tot=monto-des;
                }
                else
                {
                    if (monto >= 3000)
                    {
                        des=monto*0.3;
                        tot=monto-des;
                    }
                }
            }
            Console.WriteLine("El monto de su compra fue "+monto);
            Console.WriteLine("El descuento de su compra fue de "+des);
            Console.WriteLine("El total de su compra fue de "+tot);
        }
        }
        }