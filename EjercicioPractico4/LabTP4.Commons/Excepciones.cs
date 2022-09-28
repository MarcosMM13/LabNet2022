using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP4.Commons
{
    public class ExcepcionesId : Exception
    {
        public int Id { get; private set; }
        public ExcepcionesId(int id) : base($"No existe el id {id}  ingresado")
        {
            Id = id;
        }      
    }
}
