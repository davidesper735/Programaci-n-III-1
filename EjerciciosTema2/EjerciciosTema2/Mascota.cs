using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema2
{
    internal class Mascota
    {
        string nombre;

        public Mascota(string nombre)
        {
            this.nombre = nombre;
        }

        public void getNombre()
        {
            Console.WriteLine(nombre);
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public static void HacerTruco()
        {
            Console.WriteLine("¡Mira lo que puedo hacer!");
        }
    }
}
