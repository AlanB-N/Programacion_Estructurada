// Fecha:12/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Estructura switch 2*/
using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
namespace Programa33
{
    class Program
    {
        static void Main(String[] args)
        {
            int z1=0;
            do
            {
                
                int z=0;
                Console.WriteLine("Super Programa Recargada");
                Console.WriteLine("1- Programa con Estructura for 1");
                Console.WriteLine("2- Programa con varios progrmas SWITCH 1");
                Console.WriteLine("3- Programa de Conversiones y mas..");
                z=Convert.ToInt32(Console.ReadLine());

                switch (z)
                {
                    case 1:
                    {
                        Console.BackgroundColor=ConsoleColor.Blue;
                        int edad=0,i=0, opc1=0;
                    do
                    {
                        Console.WriteLine("Programa1");
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
                        Console.WriteLine("Desea otra operacion? 1= si 2= no (subprograma)");
                        opc1=Convert.ToInt32(Console.ReadLine());
                    } while (opc1==1);
                  break;  
                }
                case 2:
                {
                    Console.BackgroundColor=ConsoleColor.Cyan;
                    int num=0,opc=0,i=0,op=0;
                    double b,h,ar,per,sum=0,comp,des,tot;
                        do
                        {
                            Console.WriteLine("Programa 2");
                            Console.WriteLine("Menu de Opciones");
                            Console.WriteLine("Seleccione operacion a trabajar");
                            Console.WriteLine("1-Media 5 num");
                            Console.WriteLine("2-Area y Perimetro de un triangulo equilatero");
                            Console.WriteLine("3- Compra y descuento");
                            Console.WriteLine("4-Numero par o impar");
                            Console.WriteLine("Elija una opcion");
                            opc=Convert.ToInt32(Console.ReadLine());

                        switch (opc)
                        {
                            case 1:{
                                for (i = 1; i <= 5;i++)
                                {
                                    Console.WriteLine("Ingrese numero");
                                    num=Convert.ToInt32(Console.ReadLine());
                                    sum=sum+num;
                                }
                                tot=sum/5;
                                Console.WriteLine("La media es de "+tot);
                            break;
                            }

                            case 2:
                            {
                                Console.WriteLine("Ingrese base");
                                b=Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Ingrese altura");
                                h=Convert.ToDouble(Console.ReadLine());
                                ar=(b*h)/2;
                                per=3*b;
                                Console.WriteLine("el area es "+ar);
                                Console.WriteLine("El perimetro es "+per);    
                            break;
                            }
                            case 3:
                            {
                            Console.WriteLine("INgrese compra");
                            comp=Convert.ToInt32(Console.ReadLine());
                            des=comp*0.15;
                            tot=comp-des;
                            Console.WriteLine("La compra es de "+comp);
                            Console.WriteLine("el descuento es de "+des);
                            Console.WriteLine("el total de su compra es "+tot);
                            break;
                            }

                            case 4:
                            {
                            Console.WriteLine("Ingrese numero a evaluar");
                            num=Convert.ToInt32(Console.ReadLine());
                            String r=(num%2==0)?"Par":"Impar";
                            Console.WriteLine(r);
                            break;
                            }
                        
                            default:
                            {
                            Console.WriteLine("Elija una opcion valida");
                            break;
                            }
                            }
                        Console.WriteLine("Desea otra operacion? 1= si 2= no");
                        op=Convert.ToInt32(Console.ReadLine());
                        } while (op==1);
           
                    
                    break;
                    }
                    case 3:
                    {
                        Console.BackgroundColor=ConsoleColor.Yellow;
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
                            {
                            Console.WriteLine("Ingrese los KM a convertir");
                            km=Convert.ToDouble(Console.ReadLine());
                            cm=km*100000;
                            Console.WriteLine("Los centimetros de "+km+" son "+cm);
                            break;
                            }
                            case 2:
                            {
                            Console.WriteLine("Ingrese grados centigrados");
                            C=Convert.ToDouble(Console.ReadLine());
                            F=(1.8*C)+32;
                            Console.WriteLine("Los grados Farenheith son "+F);
                            break;
                            }

                            case 3:
                            {
                            Console.WriteLine("Ingrese litros");
                            lit=Convert.ToDouble(Console.ReadLine());
                            gal=lit/3.78541;
                            Console.WriteLine("Los galones son "+gal);
                            break;
                            }

                            case 4:
                            {
                            Console.WriteLine("Ingrese numero a evaluar");
                            num=Convert.ToInt32(Console.ReadLine());
                            double suma=num;
                                for (i = 1; i < num; i++)
                                {
                                    suma=suma*i;
                                }
                                Console.WriteLine(suma);
                            break;
                            }    
                            default:
                            {
                            Console.WriteLine("Ingrese opcion valida");
                            break;
                            }
                        }

                            Console.WriteLine("Desea otra operacion? 1= si 2= no");
                            op=Convert.ToInt32(Console.ReadLine());    
                        } while (op==1);

                    break;
                    }
                        default:
                    {
                        Console.WriteLine("Elija una opcion valida");
                        break;
                    }
                }

                Console.WriteLine("Desea otra operacion? 1= si 2= no (Programa Principal)");
                z1=Convert.ToInt32(Console.ReadLine()); 
            } while (z1==1);
        

        }
    }
}
    