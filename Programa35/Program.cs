// Fecha:12/032026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Serie Fibonacci*/
using System;
namespace Programa34
{
    class Program
    {
        static void Main(String[] args)
        {
            int opc2=0;
           do
           {
                int max,inicioA=0,inicioB=1;
                Console.WriteLine("Hola");
                Console.WriteLine("Bievenido a la serie Fibonacci");
                Console.WriteLine("Inserte tope maximo para la serie");
                max=Convert.ToInt32(Console.ReadLine());
                Program.serieFibonacci(max,inicioA,inicioB);
                Console.WriteLine(" Menu Principal Desea otra operacion? 1= si 2= no ");
                opc2=Convert.ToInt32(Console.ReadLine()); 
           } while (opc2==1);

        } 
        static void serieFibonacci(int max,int inicioA, int inicioB)
        {
            int suma;
            suma=inicioA+inicioB;
            if (suma > max)
            {
                return;
            }
            Console.WriteLine(suma+ " ");
            serieFibonacci(max,inicioB,suma);
        }
    }
}