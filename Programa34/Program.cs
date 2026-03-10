// Fecha:12/02/2026
//Autor: A.B.N
// Cuatrimestre y grupo: 2º E
//Version: 1

/* Estructura switch 2*/

using System;
class Program34
{
    static void Main(String[] args)
    {
        int opc,opc2;
        Console.WriteLine("Hola bienvenido al superPrograma patentado por mi jeje");
        do
        {
            Console.Clear();
            Console.WriteLine("Menu de Figuras");
            Console.WriteLine("1-Cubo o Hexaedro");
            Console.WriteLine("2-Paralelepipedo o Ortoedro");
            Console.WriteLine("3-Piramide");
            Console.WriteLine("4-Cilindro");
            Console.WriteLine("5-Cono");
            Console.WriteLine("6-esfera");
            Console.WriteLine("Elija opcion");
            opc=Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Cubo");
                        Console.WriteLine("SuperPrograma v2");
                        Console.WriteLine("Elija que desea calcular");
                        Console.WriteLine("1-Area");
                        Console.WriteLine("2-Volumen");
                        int opc3=Convert.ToInt32(Console.ReadLine());
                        switch (opc3)
                        {
                            case 1:
                                {

                                    Console.WriteLine("Area");
                                    Console.WriteLine("Ingrese arista(lado)");
                                    double arista=Convert.ToDouble(Console.ReadLine());
                                    Program34.AreaCubo(arista);
                                    break;
                                }

                            case 2:
                                {
                                    Console.WriteLine("Volumen");
                                    Console.WriteLine("Ingrese arista(lado)");
                                    double arista=Convert.ToDouble(Console.ReadLine());
                                    Program34.VolCubo(arista);

                                    break;
                                }

                            default:
                                {
                                    Console.WriteLine("Elija opcion valida");
                                    break;
                                }
                        }

                    break;
                    }
                //Paralelepipedo
                case 2:
                    {
                        Console.Clear();
                        double a,b,c;
                        Console.WriteLine("SuperPrograma v2");
                        Console.WriteLine("Paralelepipedo");
                        Console.WriteLine("Ingrese lado a");
                        a=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese lado b");
                        b=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese lado c");
                        c=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Elija que desea calcular");
                        Console.WriteLine("1-Area");
                        Console.WriteLine("2-Volumen");
                        int opc3=Convert.ToInt32(Console.ReadLine());
                        switch (opc3)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Area");
                                    Program34.ParaArea(a,b,c);
                                    

                                    break;
                                }

                            case 2:
                                {
                                    Console.WriteLine("Volumen");
                                    Program34.VolPara(a,b,c);
                                    break;
                                }

                            default:
                                {
                                    Console.WriteLine("Elija opcion valida");
                                    break;
                                }
                        }

                    break;
                    }

                //Piramide

                case 3:
                    {
                        Console.Clear();
                        double lado,altura;
                        Console.WriteLine("Piramide");
                        Console.WriteLine("SuperPrograma v2");
                        Console.WriteLine("Ingrese lado");
                        lado=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INgese altura");
                        altura=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Elija que desea calcular");
                        Console.WriteLine("1-Area");
                        Console.WriteLine("2-Volumen");
                        int opc3=Convert.ToInt32(Console.ReadLine());
                        switch (opc3)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Area");
                                    Program34.AreaPir(lado, altura);

                                    break;
                                }

                            case 2:
                                {
                                    Console.WriteLine("Volumen");
                                    Program34.VolPir(lado, altura);
                                    break;
                                }

                            default:
                                {
                                    Console.WriteLine("Elija opcion valida");
                                    break;
                                }
                        }

                    break;
                    }        
                
                //Cilindro

                case 4:
                    {
                        Console.Clear();
                        double radio,altura;
                        Console.WriteLine("Cilindro");
                        Console.WriteLine("SuperPrograma v2");
                        Console.WriteLine("Ingrese radio");
                        radio=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese altura");
                        altura=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Elija que desea calcular");
                        Console.WriteLine("1-Area");
                        Console.WriteLine("2-Volumen");
                        int opc3=Convert.ToInt32(Console.ReadLine());
                        switch (opc3)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Area");
                                    Program34.AreaCil(altura,radio);
                                    break;
                                }

                            case 2:
                                {
                                    Console.WriteLine("Volumen");
                                    Program34.VolCil(altura,radio);
                                    break;
                                }

                            default:
                                {
                                    Console.WriteLine("Elija opcion valida");
                                    break;
                                }
                        }

                    break;
                    }
                //Cono

                case 5:
                    {
                        Console.Clear();
                        double radio,altura, generatriz;
                        Console.WriteLine("Cono");
                        Console.WriteLine("SuperPrograma v2");
                        Console.WriteLine("Inserte radio");
                        radio=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese generatriz ");
                        generatriz=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese altura");
                        altura=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Elija que desea calcular");
                        Console.WriteLine("1-Area");
                        Console.WriteLine("2-Volumen");
                        int opc3=Convert.ToInt32(Console.ReadLine());
                        switch (opc3)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Area");
                                    Program34.AreaCon(radio,generatriz);

                                    break;
                                }

                            case 2:
                                {
                                    Console.WriteLine("Volumen");
                                    Program34.VolCono(radio,altura);

                                    break;
                                }

                            default:
                                {
                                    Console.WriteLine("Elija opcion valida");
                                    break;
                                }
                        }

                    break;
                    }
                //  Esfera

                case 6:
                    {
                        Console.Clear();
                        double radio;
                        Console.WriteLine("Esfera");
                        Console.WriteLine("SuperPrograma v2");
                        Console.WriteLine("ingrese radio");
                        radio=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Elija que desea calcular");
                        Console.WriteLine("1-Area");
                        Console.WriteLine("2-Volumen");
                        int opc3=Convert.ToInt32(Console.ReadLine());
                        switch (opc3)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Area");
                                    Program34.AreaEsf(radio);

                                    break;
                                }

                            case 2:
                                {
                                    Console.WriteLine("Volumen");
                                    Program34.volEsf(radio);

                                    break;
                                }

                            default:
                                {
                                    Console.WriteLine("Elija opcion valida");
                                    break;
                                }
                        }

                    break;
                    }        
                default:
                    {
                        Console.WriteLine("Elija una opcion valida");
                        break;
                    }
             
    
            }
            
            

            Console.WriteLine(" Menu Principal Desea otra operacion? 1= si 2= no ");
            opc2=Convert.ToInt32(Console.ReadLine()); 
        }while(opc2==1);
    }

    static void AreaCubo(double arista)
    {
        double area;
       
        area=6*(arista*arista);
        Console.WriteLine("El area es "+ area);
    }
    static void VolCubo(double arista)
    {
        double Volumen;
        Volumen=(arista)*(arista)*(arista);
        Console.WriteLine("El volumen es "+Volumen);
        
    }
    static void ParaArea(double a,double b,double c)
    {
        double area;
        area=2*((a*b)+(a*c)+(b*c));
        Console.WriteLine("el area es de "+ area);
    }
    static void VolPara(double a,double b, double c)
    {
        double volumen;
        volumen=a*b*c;
        Console.WriteLine("El volumen es "+volumen);
    }

    static void AreaCil(double altura,double radio)
    {
        double area;
        area=(2*3.1416*radio)*(altura+radio);
        Console.WriteLine("El area total del cilindro es "+area);
    }
    static void VolCil(double altura,double radio)
    {
        double vol;
        vol=(3.1416*(radio*radio)*altura);
        Console.WriteLine("el volumen del cilindro es "+vol);
    }
    static void AreaCon(double radio,double generatriz)
    {
        double area,pi=3.1416;
        area=(pi*(radio*radio))+(pi*radio*generatriz);
        Console.WriteLine("el area del cono es "+area);
    }
    static void VolCono(double radio,double altura)
    {
        double vol,pi=3.1416;
        vol=(pi*(radio*radio)*altura)/3;
        Console.WriteLine("el volumen del cono es "+vol);
    }
    static void AreaEsf(double radio)
    {
        double area,pi=3.1416;
        area=(4*(radio*radio)*pi);
        Console.WriteLine("el area de la esfera es de "+area);
    }
    static void volEsf(double radio)
    {
        double vol,pi=3.1416;
        vol=((4.0/3.0)*pi*(radio*radio*radio));
        Console.WriteLine("el volumen de la esfera es "+vol);
    }
    static void AreaPir(double lado,double altura)
    {
        double apBase = lado * (Math.Sqrt(3) / 2.0);
        double perimetro = 6 * lado;
        double areaBase = (perimetro * apBase) / 2.0;
        double apPiramide = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(apBase, 2));
        double areaLateral = 6 * ((lado * apPiramide) / 2.0);
        double areaTotal = Math.Round( (areaBase + areaLateral),4);
        Console.WriteLine("El area total de la piramide hexagonal es: " + areaTotal);
    }
    static void VolPir(double lado,double altura)
    {
        double apBase = lado * (Math.Sqrt(3) / 2.0);
        double areaBase = (6 * lado * apBase) / 2.0;
        double volumen = Math.Round((areaBase * altura) / 3.0,4);
        Console.WriteLine("El volumen de la piramide hexagonal es: " + volumen);
    }
}