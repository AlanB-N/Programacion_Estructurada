// Fecha 03/02/26
//Autor A.B.N
//Cuatrimestre y grupo 2E
//Version 1.0
/*Escribe un programa que tome una letra minuscula como entrada , avance 
3 posiciones en el alfabeto y muestre la nueva letra*/

using System;

namespace Programa18
{
    class Program
    {
        static void Main(String[] args)
        {
            char letra,posicion;
            Console.WriteLine("Escribe una letra ");
            letra = Console.ReadKey().KeyChar;
            posicion=(char)(letra +3);
            Console.WriteLine(" Tu letra fue "+letra+" y tu nueva letra es "+posicion);
        }
    }
}