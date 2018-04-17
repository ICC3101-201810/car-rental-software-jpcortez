using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public abstract class Vehiculo
    {
        public string tipoLicencia, tipoPermiso, patente;
        public int valor, anho;

        public Vehiculo(string tipoLicencia, string tipoPermiso, string patente, int  valor, int anho)
        {
            this.tipoLicencia = tipoLicencia;
            this.patente = patente;
            this.valor = valor;
            this.anho = anho;
            this.tipoPermiso = tipoPermiso;
        }
    }
}
