using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    class Program
    {

        static private List<Taxi> _taxis = new List<Taxi>();
        static private List<Omnibus> _omnibus = new List<Omnibus>();


        static private int _pasajerosTotal = 0;
        static private int _cantOmnibus = 5;
        static private int _cantTaxis = 5;


        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************");
            Console.WriteLine("***************TRANSPORTE PUBLICOS DE PASAJEROS***************");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("");

            AgregarOmnibus();

            Console.WriteLine("");
            Console.WriteLine("");

            AgregarTaxis();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("************************LISTA DE TAXIS************************");
            Console.WriteLine("**************************************************************");

            for (int i = 0; i < _taxis.Count; i++)
            {                
                Console.WriteLine("Taxi {0} : {1}", (i + 1), _taxis[i].pasajeros);
                Console.WriteLine("");
            }

            Console.WriteLine("**************************************************************");
            Console.WriteLine("***********************LISTA DE OMNIBUS***********************");
            Console.WriteLine("**************************************************************");

            for (int i = 0; i < _omnibus.Count; i++)
            {
                Console.WriteLine("Omnibus {0} : {1}", (i + 1), _omnibus[i].pasajeros);
                Console.WriteLine("");
            }
           

            Console.WriteLine("el total de pasajeros es de : {0}", _pasajerosTotal);


            Console.ReadKey();
        }
        private static void AgregarOmnibus()
        {
            Console.WriteLine("***********************CARGA DE OMNIBUS***********************");

           
            for (int i = 0; i < _cantOmnibus; i++)
            {
                int pasajeros = 0;
                Console.WriteLine("");

                Omnibus omnibus = new Omnibus(pasajeros);

                omnibus.Detenerse();
                Console.WriteLine("Ingrese los pasajeros para el proximo omnibus");
                pasajeros = int.Parse(Console.ReadLine());
                omnibus.pasajeros = pasajeros;
                _omnibus.Add(omnibus);
                _pasajerosTotal += pasajeros;

                omnibus.Avanzar();
            }

            Console.WriteLine("");
            Console.WriteLine("No quedan mas omnibus");
            Console.WriteLine("**************************************************************");
        }
        private static void AgregarTaxis()
        {
            Console.WriteLine("************************CARGA DE TAXIS*************************");

            for (int i = 0; i < _cantTaxis; i++)
            {               
                int pasajeros = 0;
                Console.WriteLine("");

                Taxi taxi = new Taxi(pasajeros);

                taxi.Detenerse();
                Console.WriteLine("Ingrese los pasajeros para el proximo taxi");
                pasajeros = int.Parse(Console.ReadLine());
                taxi.pasajeros = pasajeros;
                _taxis.Add(taxi);
                _pasajerosTotal += pasajeros;

                taxi.Avanzar();
            }
            Console.WriteLine("");
            Console.WriteLine("No quedan mas Taxis");
            Console.WriteLine("**************************************************************");
        }
    }
}

