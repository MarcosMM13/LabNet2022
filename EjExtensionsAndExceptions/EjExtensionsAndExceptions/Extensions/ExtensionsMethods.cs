using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjExtensionsAndExceptions.Extensions
{
    public static class ExtensionsMethods
    {
        public static int Divide(this int num1)
        {
            return num1 / 0;
        }
        public static int Divide(this int num1, int num2)
        {
            return num1 / num2;
        }
        


    }
}
