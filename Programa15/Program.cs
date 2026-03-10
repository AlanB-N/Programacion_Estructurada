//Fecha 03/02/26
//Autor A.B.N
//Cuatrimestre y grupo 2E 
/*15 Convierte una variable de tipo int a float y viceversa*/

using System;

namespace Programa15
{
    class Program
    {
        static void Main(String[]args){
            
            //convertir entero a flotante
            int entero=360;
            float f1=entero;
            Console.WriteLine("El numero entero es "+entero+ " convertido a flotante es "+f1);

            //Convertir flotante a entero
            float f2=3.1416f;
            int entero2=(int)f2;
            Console.WriteLine("El numero flotante es "+f2+ " convertido a entero es "+entero2);


        }
    }
}
