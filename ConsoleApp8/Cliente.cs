using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public abstract class Cliente
    {
        public string nombre, rut;
        public List<string> licencias;
        public List<string> permiso;
        public List<Arriendo> arrendados;

        public Cliente(string nombre, string rut)
        {
            this.nombre = nombre;
            this.rut = rut;
        }

        abstract public void AddLicencia(string tipo);
        abstract public void AddPermisos(string tipo);
        abstract public string GetTipo();
    }
}
