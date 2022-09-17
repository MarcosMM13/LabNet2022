using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros) : base(pasajeros) { }


        public override void Avanzar()
        {
            Console.WriteLine("Los pasajeros han subido al Omnibus, continua su marcha.");
        }

        public override void Detenerse()
        {
            Console.WriteLine("El Omnibus se detiene");
        }

      
    }
}
