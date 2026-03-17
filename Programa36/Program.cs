// Fecha:12/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Arreglos*/
using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main()
    {
        int opcion = 0, opc2=0;

        do
        {
             Console.WriteLine("--- MENU ---");
            Console.WriteLine("1. Nombres estudiantes");
            Console.WriteLine("2. Calificaciones y promedio");
            Console.WriteLine("3. Frutas dinamico");
            Console.WriteLine("4. Numeros al reves");
            Console.WriteLine("0. Salir");
            Console.Write("Selecciona: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    
                    string[] nombres = { "Brayan", "Brian", "Sofia", "Luis", "Ana", "Carlos", "Maria", "Jose", "Elena", "Diego" };
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine((i + 1) + ".- " + nombres[i]);
                    }
                    break;

                case 2:
                    
                    double[] calif = new double[10];
                    double suma = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write("Dame calificacion " + (i + 1) + ": ");
                        calif[i] = Convert.ToDouble(Console.ReadLine());
                        suma = suma + calif[i];
                    }
                    Console.WriteLine("Promedio es: " + (suma / 10));
                    break;

                case 3:
                    
                    Console.Write("Cuantas frutas quieres guardar?  ");
                    int tam = Convert.ToInt32(Console.ReadLine());
                    string[] frutas = new string[tam]; 
                    
                    for (int i = 0; i < tam; i++)
                    {
                        Console.Write("Nombre de fruta " + (i + 1) + ": ");
                        frutas[i] = Console.ReadLine();
                    }
                    Console.WriteLine("Las frutas son:");
                    for (int i = 0; i < tam; i++)
                    {
                        Console.WriteLine("- " + frutas[i]); 
                    }
                    break;

                case 4:
                    // 5 números en orden inverso
                    int[] nums = new int[5];
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("Numero " + (i + 1) + ": ");
                        nums[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Al reves son:");
                    // El truco está en empezar el for desde 4 hasta 0
                    for (int i = 4; i >= 0; i--)
                    {
                        Console.WriteLine(nums[i]);
                    }
                    break;
            }
            
            Console.WriteLine(" Menu Principal Desea otra operacion? 1= si 2= no ");
            opc2=Convert.ToInt32(Console.ReadLine()); 
        } while (opc2==1);
            
        
        
    }
}