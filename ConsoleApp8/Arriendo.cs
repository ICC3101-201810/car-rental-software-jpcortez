using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Arriendo
    {
        public string id;
        public Cliente cliente;
        public Vehiculo vehiculo;
        public DateTime i, f;
        public List<Accesorios> accesorios;
        public int costo;

        public Arriendo(Cliente cliente, Vehiculo vehiculo, DateTime i, DateTime f)
        {
            this.cliente = cliente;
            this.vehiculo = vehiculo;
            this.i = i;
            this.f = f;
        }

        public void AddAccesorio(Accesorios accesorio)
        {
            accesorios.Add(accesorio);
        }

        public int CostoTotal()
        {
            foreach (Accesorios accesorio in accesorios)
            {
                costo += accesorio.costo;
            }
            costo += vehiculo.valor;
            return costo;
        }

        public bool VerificarLicencia()
        {
            if (cliente.GetTipo() == "Persona")
            {
                foreach (string i in cliente.licencias)
                {
                    if (i == vehiculo.tipoLicencia)
                    {
                        return true;
                    }
                }
            }

            else if (cliente.GetTipo() == "Empresa")
            {
                foreach (string i in cliente.permiso)
                {
                    if (i == vehiculo.tipoPermiso)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
