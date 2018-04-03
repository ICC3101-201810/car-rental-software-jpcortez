using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Licencia
    {
        public List<string> licencia;
        public string rut;



        public void AddLicencia(string rut)
        {
            licencia.Add(rut);
        }
        public bool RevisarLicencia(Persona persona)
        {
            foreach (string i in licencia)
            {
                if (persona.rut == i)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
