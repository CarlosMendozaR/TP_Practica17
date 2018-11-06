using System;

namespace Estructuras
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("---TIENDA DE APARATOS ELECTRÓNICOS---\n*Nota: Este programa no tiene interacción con el usuario.*\n");
            Console.WriteLine("Hola. Los electrónicos que llegaron a la tienda son los siguientes.");

            Marca[] tienda = new Marca[2];
            tienda[0].Tablets = new Tablet[2];
            tienda[1].Tablets = new Tablet[2];
            tienda[0].Celulares = new Celular[2];
            tienda[1].Celulares = new Celular[2];

            tienda[0].Nombre = "Samsung";
            tienda[1].Nombre = "Apple";

            //tablets
            tienda[0].Tablets[0].Modelo = "Galaxy Note 7";
            tienda[0].Tablets[1].Modelo = "Galaxy Prime";
            tienda[0].Tablets[0].Año = 2017;
            tienda[0].Tablets[1].Año = 2015;
            tienda[1].Tablets[0].Modelo = "Ipad 6";
            tienda[1].Tablets[1].Modelo = "Ipad Pro";
            tienda[1].Tablets[0].Año = 2017;
            tienda[1].Tablets[1].Año = 2018;

            //celulares
            tienda[0].Celulares[0].Modelo ="S7";
            tienda[0].Celulares[1].Modelo ="S8";
            tienda[0].Celulares[0].Año = 2016;
            tienda[0].Celulares[1].Año = 2017;
            tienda[1].Celulares[0].Modelo = "Iphone 8";
            tienda[1].Celulares[1].Modelo = "Iphone X";
            tienda[1].Celulares[0].Año = 2017;
            tienda[1].Celulares[1].Año = 2018;

            for (int a=0; a<tienda.Length; a++)
            {
                Console.WriteLine("\nMARCA: "+tienda[a].Nombre+"\n");
                for (int b = 0; b < tienda.Length; b++)
                {
                    Console.WriteLine("  TABLET "+(b+1));
                    Console.WriteLine("    "+tienda[a].Tablets[b].Modelo+" - "+tienda[a].Tablets[b].Año);
                }
                for (int c=0; c<tienda.Length; c++)
                {
                    Console.WriteLine("  CELULAR "+(c+1));
                    Console.WriteLine("    "+tienda[a].Celulares[c].Modelo+" - "+tienda[a].Celulares[c].Año);
                }
                Console.WriteLine("\n");
            }
        }
    }

    public struct Marca
    {
        public string Nombre;
        public Tablet [] Tablets;
        public Celular [] Celulares;
    }

    public struct Tablet
    {
        public string Modelo;
        public int Año;
    }

    public struct Celular
    {
        public string Modelo;
        public int Año;
    }
}
