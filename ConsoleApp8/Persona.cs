using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Persona : Cliente
    {
        public string nombre, rut;

        public Persona(string nombre, string rut)
        {
            this.nombre = nombre;
            this.rut = rut;
        }

        
    }
}
