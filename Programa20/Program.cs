//Fecha 03/02/26
//Autor A.B.N
//Cuatrimestre y grupo 2E
//Version 1.0
/*20 Usa el formateo de cadenas para mostrar una fecha en formato (dia/mes/anio)*/

using System;

namespace Programa20
{
    class Program
    {
        static void Main(String[] args)
        {
            String formato;
            DateTime fecha= DateTime.Now;
            formato= fecha.ToString("dd/MM/yyyy");
            Console.WriteLine("FECHA CON FORMATO WOW "+formato);
        }
    }
}