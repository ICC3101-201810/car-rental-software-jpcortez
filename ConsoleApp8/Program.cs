using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            List<Cliente> clientes = new List<Cliente>();
            List<Arriendo> arriendos = new List<Arriendo>();
            List<Vehiculo> arrendados = new List<Vehiculo>();
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            Console.WriteLine("Bienvenido !");

            while (true)
            {
                Console.WriteLine("Escoja que tipo de acciones desea realizar");
                Console.WriteLine("--------------------------------------\n1.- Crear Objetos\n2.- Administrativo\n3.- Salir\n--------------------------------------\n");
                string qq = Console.ReadLine();
                #region Verificar Opcion
                try
                {
                    int respuesta = int.Parse(qq);
                    if (respuesta < 0 || respuesta > 3)
                    {
                        throw new DivideByZeroException();
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nElija una opción válida entre 1 y 3\n");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    continue;
                }
                #endregion

                if (qq == "1")
                #region Crear cosas
                {
                    Console.WriteLine("\nQue desea crear?\n--------------------------------------\n1.- Sucursal\n2.- Cliente\n3.- Vehiculo\n4.- Volver\n--------------------------------------\n");
                    string q = Console.ReadLine();
                    try
                    {
                        int respuesta = int.Parse(q);
                        if (respuesta < 0 || respuesta > 5)
                        {
                            throw new DivideByZeroException();
                        }
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nElija una opción válida entre 1 y 4\n");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        continue;
                    }
                    if (q == "1")
                    {
                        Console.WriteLine("\nIngrese la ID de su sucursal");
                        Sucursal sucursal1 = new Sucursal(Console.ReadLine());
                        sucursales.Add(sucursal1);

                    }
                    if (q == "2")
                    {
                        Console.WriteLine("\nDesea crear una persona o una institucion?");
                        string qqq = Console.ReadLine();
                        if (qqq == "persona") //POR FALTA DE TIEMPO NO HARE UN TRY PARA CADA DECISION//
                        {
                            Console.WriteLine("\nIngrese el rut");
                            string rut = Console.ReadLine();
                            Console.WriteLine("nIngrese el nombre");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("\nIngrese domicilio");
                            string domicilio = Console.ReadLine();
                            Persona p = new Persona(nombre, rut, domicilio);
                            clientes.Add(p);
                        }
                        if (qqq == "institucion")
                        {
                            Console.WriteLine("\nIngrese el rut");
                            string rut = Console.ReadLine();
                            Console.WriteLine("\nIngrese el nombre");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("\nIngrese domicilio");
                            string direccion = Console.ReadLine();
                            Empresa e = new Empresa(nombre, rut, direccion);
                            clientes.Add(e);
                        }
                    }
                    if (q == "3")
                    {
                        Console.WriteLine("\nA que sucursal pertenecera el vehiculo?");
                        string ids = Console.ReadLine();
                        Console.WriteLine("\nDesea crear una moto o un auto?");
                        string qqqq = Console.ReadLine();
                        if (qqqq == "moto")
                        {
                            Console.WriteLine("\nIngrese la patente");
                            string patente = Console.ReadLine();
                            Console.WriteLine("\nIngrese el anho");
                            int anho = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nIngrese el precio");
                            int precio = int.Parse(Console.ReadLine());
                            Motos m = new Motos("LMoto", "PMoto", patente, precio, anho);
                            vehiculos.Add(m);
                            foreach (Sucursal s in sucursales)
                            {
                                if (ids == s.id)
                                {
                                    s.AddVehiculo(m);
                                }
                            }
                        }
                        if (qqqq == "auto")
                        {
                            Console.WriteLine("\nIngrese la patente");
                            string patente = Console.ReadLine();
                            Console.WriteLine("\nIngrese el anho");
                            int anho = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nIngrese el precio");
                            int precio = int.Parse(Console.ReadLine());
                            Autos a = new Autos("LAuto", "PAuto", patente, precio, anho);
                            vehiculos.Add(a);
                            foreach (Sucursal s in sucursales)
                            {
                                if (ids == s.id)
                                {
                                    s.AddVehiculo(a);
                                }
                            }
                        }
                    }
                    if (q == "4")
                    {
                        continue;
                    }
                }
                #endregion


                if (qq == "2")
                #region Administrar Arriendos
                {
                    Console.WriteLine("\nEscoja una accion.\n");
                    Console.WriteLine("--------------------------------------\n1.- Arrendar un vehiculo\n2.- Recibir un vehiculo\n3.- Volver\n--------------------------------------\n");
                    string w = Console.ReadLine();
                    Console.WriteLine("");
                    if (w == "1")
                    {
                        Console.WriteLine("Ingrese la ID de la sucursal en la que realizara el arriendo");
                        string idq = Console.ReadLine();
                        Sucursal ss = sucursales.First(s => s.id == idq);
                        Console.WriteLine("\nIngrese el rut del cliente: ");
                        string rut = Console.ReadLine();
                        Cliente cc = clientes.First(s => s.rut == rut);
                        Console.WriteLine("\nIngrese patente del vehiculo: ");
                        string patente = Console.ReadLine();
                        Vehiculo vv = ss.vehiculos.First(s => s.patente == patente);
                        DateTime inicio = DateTime.Now;
                        Console.WriteLine("Ingrese hasta que anho arrendara");
                        int anho = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese hasta que mes arrendara");
                        int mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese hasta que dia arrendara");
                        int dia = int.Parse(Console.ReadLine());
                        DateTime final = new DateTime(anho, mes, dia);
                        Console.WriteLine("Ingrese el costo del arriendo");
                        int costo = int.Parse(Console.ReadLine());
                        Arriendo a = new Arriendo(cc, vv, inicio, final);

                        foreach (Sucursal s in sucursales)
                        {
                            if (s.id == idq)
                            {
                                s.AddArriendo(a);
                            }
                        }
                    }
                    if (w == "3")
                    {
                        continue;
                    }
                }
                #endregion

                if (qq == "3")
                {
                    break;
                }

            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Beep();
            Console.WriteLine("\nGracias por utilizar el programa! :)\n \nHasta la proxima.");
            Console.ReadKey();
        }
    }
}
