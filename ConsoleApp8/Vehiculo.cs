using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Vehiculo
    {
        public string tipo, tipoLicencia, tipoPermiso, patente;
        public int valor, anho;

        public Vehiculo( string tipo, string tipoLicencia, string tipoPermiso, string patente, int  valor, int anho)
        {
            this.tipo = tipo;
            this.tipoLicencia = tipoLicencia;
            this.patente = patente;
            this.valor = valor;
            this.anho = anho;
            this.tipoPermiso = tipoPermiso;
        }
    }
}
