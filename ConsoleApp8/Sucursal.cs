using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Sucursal
    {
        public string id;
        public List<Vehiculo> vehiculos;
        public List<Arriendo> arriendos;

        public Sucursal(string id)
        {
            this.id = id;
        }

        public void AddVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }

        public void AddArriendo(Arriendo arriendo)
        {
            if (arriendo.VerificarLicencia())
            {
                arriendos.Add(arriendo);
                arriendo.cliente.arrendados.Add(arriendo);
            }
            else
            {
                Console.WriteLine("No posee la licencia necesaria, no se pudo agregar.\n");
            }
        }
    }
}
