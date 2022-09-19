using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjExtensionsAndExceptions
{
    public abstract class ValidateMethods
    {       
        public static void NegativeNumberVal(int? num1)
        {
            while (num1 < 0)
            {
                Console.WriteLine("Ha ingresado un valor negativo, por favor intente nuevamente.");
                num1 = int.Parse(Console.ReadLine());
            }
        }
        public static void NullNumberVal(int? num1)
        {            
            while (num1 == null)
            {
                Console.WriteLine("No ha ingresado un valor, por favor intente nuevamente.");
                num1 = int.Parse(Console.ReadLine());
            }
        }
        public static void CharVal(string num1)
        {
            int n = 0;
            bool result = int.TryParse(num1, out n);

            while (result != true)
            {
                Console.WriteLine("Ha ingresado un caracter, por favor intente nuevamente.");
                num1 = Console.ReadLine();
            }          
        }        
    }
}

