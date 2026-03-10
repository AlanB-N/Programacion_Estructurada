// Fecha:124/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Funciones*/
using System;
using System.Formats.Asn1;
namespace Funcion
{
    class ProgramaFunciones
    {
        static void Main(String[] args)
        {
            double entrada=0;
            double salida=0;
            //Retornando salida
            Console.WriteLine("Calcula el area de un circulo");
            Console.WriteLine("Ingrese valor del radio");
            entrada=Convert.ToDouble(Console.ReadLine());
            //Llamando a la funcion instanciado la clase para calcular
            salida=ProgramaFunciones.CalcularAreaCirculo(entrada);
            Console.WriteLine("El area el circulo es "+salida);

            //Sin retornar 
            Console.WriteLine("Calcula el area de un circulo");
            Console.WriteLine("Ingresa el valor del radio");
            entrada=Convert.ToDouble(Console.ReadLine());
            ProgramaFunciones.CalcularAreaCirculo2(entrada);

            //Ni entradas ni salidas
            ProgramaFunciones.CalcularAreaCirculo3();




        }

        //Funciones fuera del programa principal

        static double CalcularAreaCirculo(double radio)
        {
            double area=0;
            area=3.146*(radio*radio);
            return area;
        }

        static void CalcularAreaCirculo2(double radio)
        {
            double area=0;
            area=3.146*(radio*radio);
            Console.WriteLine("El area del circulo es de "+ area);

        }
        static void CalcularAreaCirculo3()
        {
            double area=0;
            double entrada=0;

            Console.WriteLine("Calcula el area de un circulo");
            Console.WriteLine("Ingresa el valor del radio");
            entrada=Convert.ToDouble(Console.ReadLine());
            area=3.146*(entrada*entrada);
            Console.WriteLine("El area del circulo es de "+area);
        }

        
    }
}