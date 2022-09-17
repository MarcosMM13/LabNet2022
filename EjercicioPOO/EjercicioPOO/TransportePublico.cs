using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    public abstract class TransportePublico
    {
        private int _cantidadPasajeros;
        public int pasajeros
        {
            get { return _cantidadPasajeros; }

            set { _cantidadPasajeros = value; }
        }
        
        public TransportePublico(int pasajeros)
        {
            _cantidadPasajeros = pasajeros;
        }
        public abstract void Avanzar();
        public abstract void Detenerse();
       
    }
}
