using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP4Console.UI
{
    public interface IPresentacion<T>
    {
        void Listar();
        void Alta();
        void Baja();
        void Modificacion();

    }
}
