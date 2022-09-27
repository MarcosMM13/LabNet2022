using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP4Console.UI
{
    public abstract class BaseUI<T> : IPresentacion<T>
    {
        public abstract void Listar();
        public abstract void Alta();
        public abstract void Baja();
        public abstract void Modificacion();
    }
}
