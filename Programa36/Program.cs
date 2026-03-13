// Fecha:12/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Arreglos*/
using System;
namespace Programa36
{
    class Program
    {
        static void Main(String[] args)
        {
            int opc2;
            do
            {
                int opc;
                Console.WriteLine("Programa de Arreglos");
                Console.WriteLine("Elija un caso");
                Console.WriteLine("1.Arreglo estatico9 con nombres");
                Console.WriteLine("2- Arrelgo dinamico Calificaciones");
                Console.WriteLine("3- Arreglo dinamico que solicite Frutas");
                Console.WriteLine("4- Arreglo estatico que solicite y guarde 5 num inveros");
                opc=Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        {
                            Program.arregloEstudiantes();
                            break;
                        }
                    case 2:
                        {
                            
                            break;
                        }
                    case 3:
                        {
                            
                            break;
                        }
                    case 4:
                        {
                            
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Ingrese una opcion valida");
                            break;
                        }
                }


                Console.WriteLine(" Menu Principal Desea otra operacion? 1= si 2= no ");
                opc2=Convert.ToInt32(Console.ReadLine()); 
            } while (opc2==1);
            
        }
    static void arregloEstudiantes()
        {
            String Lista[]={Juan,Pedro};
            for (int i = 0; i < Lista.length; i++)
           {
                Console.WriteLine(Lista[i]);
            }

        }    
    }
}