using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjExtensionsAndExceptions.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException() : base("Esto es una excepcion personalizada")
        {

        }
    }
}
