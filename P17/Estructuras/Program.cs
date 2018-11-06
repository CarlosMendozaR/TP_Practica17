using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
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
