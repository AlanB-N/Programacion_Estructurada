// Fecha:12/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Estructura switch 1*/

using System;


namespace Programa31{

    class Program{

        static void Main(String[] args)
        {
            int num=0,opc=0,i=0,op=0;
            double b,h,ar,per,sum=0,comp,des,tot;
            do
            {
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
                case 1:
                    for (i = 1; i <= 5;i++)
                    {
                        Console.WriteLine("Ingrese numero");
                        num=Convert.ToInt32(Console.ReadLine());
                        sum=sum+num;
                    }
                    tot=sum/5;
                    Console.WriteLine("La media es de "+tot);
                break;

                case 2:
                    Console.WriteLine("Ingrese base");
                    b=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese altura");
                    h=Convert.ToDouble(Console.ReadLine());
                    ar=(b*h)/2;
                    per=3*b;
                    Console.WriteLine("el area es "+ar);
                    Console.WriteLine("El perimetro es "+per);    
                break;

                case 3:
                Console.WriteLine("INgrese compra");
                comp=Convert.ToInt32(Console.ReadLine());
                des=comp*0.15;
                tot=comp-des;
                Console.WriteLine("La compra es de "+comp);
                Console.WriteLine("el descuento es de "+des);
                Console.WriteLine("el total de su compra es "+tot);
                break;

                case 4:
                Console.WriteLine("Ingrese numero a evaluar");
                num=Convert.ToInt32(Console.ReadLine());
                String r=(num%2==0)?"Par":"Impar";
                Console.WriteLine(r);
                break;
               
                default:
                Console.WriteLine("Elija una opcion valida");
                break;
                }
            Console.WriteLine("Desea otra operacion? 1= si 2= no");
            op=Convert.ToInt32(Console.ReadLine());
            } while (op==1);
           

        }
    }
}