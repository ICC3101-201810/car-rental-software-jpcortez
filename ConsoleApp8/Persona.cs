using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Persona : Cliente
    {
        public string domicilio;

        public Persona(string nombre, string rut, string domicilio) : base(nombre, rut)
        {
            this.domicilio = domicilio;
        }

        public override void AddLicencia(string tipo)
        {
            licencias.Add(tipo);
        }
        public override void AddPermisos(string tipo)
        {
        }
        public override string GetTipo()
        {
            return "Persona";
        }
    }
}
