// Fecha:12/02/2026
//Autor: Equipo 1
// Cuatrimestre y grupo: 2º E
//Version: 1.0

/* Ferreteria*/
using System;
using System.IO;//para leer los archivos
namespace Ferreteria
{
    class ProgramFerr
    {
        static void Main(String[] args)
        {
            String path="inventario.txt";

            //Menu Principal
            int opc2=0;
            do
            {
                int opc;
                DateTime time=DateTime.Now;
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                Console.WriteLine("----------Ferreteria Miaurtillo-------");
                Console.WriteLine("----------"+time+"----------");
                Console.WriteLine("-----Carretera Ixmiquilpan-Capula Km. 4 El Nith-----");
                Console.WriteLine("----------RFC:GATOIXMI1234----------");
                Console.WriteLine("Bienvenido");
                Console.WriteLine("Elija una de las opciones para comenzar");
                Console.WriteLine("1.---Punto de Venta");
                Console.WriteLine("2---Inventario");
                Console.WriteLine("3-Compras");
                //Console.WriteLine("4---Reportes");
                opc=Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Punto de Venta");
                            break;
                        }  
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Inventario");
                            ProgramFerr.Inventario();

                            break;
                        }
                        case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Compras");
                            break;
                        }    

                    default:
                        {
                            Console.ForegroundColor=ConsoleColor.DarkGray;
                            Console.WriteLine("Ingrese una opcion válida");
                            break;
                        }
                }
                Console.WriteLine(" Menu Principal Desea otra operacion? 1= si 2= no MENU PRINCIPAL");
                opc2=Convert.ToInt32(Console.ReadLine()); 
            } while (opc2==1);
            


        }
        static void Inventario()
        {
            
            int opc2=0;
            do
            {
                    String ruta="Inventario.txt";
                if (File.Exists(ruta))
                {
                    string[] lineas=File.ReadAllLines(ruta);
                }
                Console.Clear();
                Console.WriteLine("Inventario");
                Console.WriteLine("1.Agregar Producto");
                Console.WriteLine("2.Actualizar producto");
                Console.WriteLine("3.Eliminar producto");
                Console.WriteLine("4.Consultar Producto");
                int opc=Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Agregar Producto");
                            String[] Lista= ProgramFerr.solicitarDatos();
                            String codigo=Lista[0];
                            String detalle=Lista[1];
                            double precio=Convert.ToDouble(Lista[2]);
                            int cantidad=Convert.ToInt32(Lista[3]);
                            ProgramFerr.agregarProdcutos(codigo,detalle,precio,cantidad,ruta);
                            
                            
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Actualizar Prodcuto");
                            break;
                        }    
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Eliminar Productos");
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Consultar producto");
                            
                            break;
                        }

                    default:
                        {
                            Console.ForegroundColor=ConsoleColor.DarkGray;
                            Console.WriteLine("Ingrese una opcion válida");
                            break;
                        }
                }

                    
                Console.WriteLine(" Menu Principal Desea otra operacion? 1= si 2= no ");
                opc2=Convert.ToInt32(Console.ReadLine()); 
                } while (opc2==1);
            

        }

        static void puntoVenta()
        {
            
        }
    
        static void compras()
        {
            
        }
        
        static string[] solicitarDatos()
        {
            Console.WriteLine("Ingrese codigo del producto");
            string codigo =Console.ReadLine();

            Console.WriteLine("Ingrese detalle del producto");
            string detalle =Console.ReadLine();
            
            Console.WriteLine("Ingrese precio del prodcuto");
            double precio =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese cantidad del prodcuto");
            int cantidad =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Producto agregado correctamente");


            return new string[]{codigo,detalle,precio.ToString(),cantidad.ToString()};
            
        }
        static void agregarProdcutos(String codigo,String detalle,double precio,int cantidad,string ruta)
        {
            using (StreamWriter sw=File.AppendText(ruta))
            {
                sw.WriteLine(codigo + "," + detalle + "," + precio +"," + cantidad );
            }
        }
    }
}