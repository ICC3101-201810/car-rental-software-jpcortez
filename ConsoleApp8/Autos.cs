using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Autos : Vehiculo
    {
        public string tipo;
        public Autos(string tipoLicencia, string tipoPermiso, string patente, int valor, int anho) : base(tipoLicencia, tipoPermiso, patente, valor, anho)
        {
            this.tipo = "auto";
        }
    }
}
