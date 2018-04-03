using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Autorizacion
    {
        public List<string> autorizacion;
        public string rut;



        public void AddLicencia(string rut)
        {
            autorizacion.Add(rut);
        }
        public bool RevisarAutorizacion(Empresa empresa)
        {
            foreach (string i in autorizacion)
            {
                if (empresa.rut == i)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

