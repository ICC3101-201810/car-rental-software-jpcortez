
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Empresa : Cliente
    {
        public string ubicacion;

        public Empresa(string nombre, string rut, string ubicacion) : base(nombre, rut)
        {
            this.ubicacion = ubicacion;
        }
        public override void AddLicencia(string tipo)
        {
        }
        public override void AddPermisos(string tipo)
        {
            permiso.Add(tipo);
        }
        public override string GetTipo()
        {
            return "Empresa";
        }
    }

}
