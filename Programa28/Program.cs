// Fecha:05/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Programa 28 Sistema de becas*/

using System;
using System.Diagnostics;

namespace Programa28{

    class Program{

        static void Main(String[] args)
        {
            int edad=0,sem=0;
            double tot=0,bon=0;
            Char gen;
            Console.WriteLine("CUal es su edad?");
            edad=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuantas semanas se deben");
            sem=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Que genero eres?");
            gen=Convert.ToChar(Console.ReadLine());
            if(edad>=17 && edad <= 20)
            {
                if (gen == 'H')
                    {
                        tot=sem*1800;
                    }
                    else
                    {
                        tot=sem*2000;
                    } 
                     
                }
            if(edad>=21 && edad <= 23)
                {
                    if (gen == 'H')
                    {
                        tot=sem*2300;
                    }
                    else
                    {
                        tot=sem*2100;
                    }   
                }
            if (edad > 23)
            {
                tot=sem*1000;
            }

            if (sem < 4)
            {
                bon=tot*.10;
                tot=tot+bon;
            }
            Console.WriteLine("Esta es tu edad "+edad);
            Console.WriteLine("Estas son las semanas "+sem);
            Console.WriteLine("Este es tu genero "+gen);
            Console.WriteLine("Este es tu bono"+bon);
            Console.WriteLine("El total de su beca "+tot);
    }}}
