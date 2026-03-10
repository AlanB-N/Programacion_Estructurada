//Fecha 17/02/26
//Autor A.B.N
//Cuatrimestre y grupo:2E
//Version:1.0
/*Examen Hacer lo del examen*/

using System;
namespace Examen2
{
    class Program
    {
        static void Main(String[] args)
        {
            int opc;

            Console.WriteLine("Hola");
            Console.WriteLine("Menu seleccionador");
            Console.WriteLine("1- Nombre y apellido y su longitud");
            Console.WriteLine("2-Mayor o menor de edad");
            Console.WriteLine("3-Calcula el total a pagar de una compra");
            opc=Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                int longitud=0;
                String nom,apeM,apeP,n,mayus;
                Console.WriteLine("Ingrese nombre");
                nom=Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingrese apellido materno");
                apeM=Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingrese apellido paterno");
                apeP=Convert.ToString(Console.ReadLine());
                n=nom+apeM+apeP;
                longitud=n.Length;
                mayus=n.ToUpper();
                Console.WriteLine(" "+n);
                Console.WriteLine("El numero de caracteres es "+longitud);
                Console.WriteLine("El nuevo nombre es "+mayus);
                break;
                case 2:
                    int edad=0;
                    Console.WriteLine("Ingrese edad");
                    edad=Convert.ToInt32(Console.ReadLine());
                    if (edad>=18)
                    {
                        Console.WriteLine("Eres Mayor de edad");
                    }
                    else
                    {
                        
                        for (int i = 0; i < edad; i++)
                        {
                            Console.WriteLine("Te saludo desde Narnia");
                        }
                    }
                break;
                case 3:
                    DateTime f=DateTime.Now;
                    double compra,des=0,tot=0,iva=.16,total=0,t=0;
                    Console.WriteLine("Ingrese el monto de la compra");
                    compra=Convert.ToDouble(Console.ReadLine());
                    if (compra>5000)
                    {
                        des=compra*.3;
                        tot=compra-des;
                    }
                    if (compra>=3000&& compra<=5000)
                    {
                        des=compra*.1;
                        tot=compra-des;
                    }
                    if (compra<3000)
                    {
                        tot=compra;
                    }
                    total=compra*iva;
                    t=tot+total;
                    Console.WriteLine("La fecha de la compra es "+f);
                    Console.WriteLine("El monto de su compra es de "+compra);
                    Console.WriteLine("El descuento que se aplico es de "+des);
                    Console.WriteLine("El iva aplicado es "+total);
                    Console.WriteLine("El total de su compra es de "+t);
                break;
                default:
                Console.WriteLine("Elija una opcion valida");
                break;
            }

            
        }
    }
}