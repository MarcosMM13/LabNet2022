using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjExtensionsAndExceptions
{
    public class Logic : Exception
    {
        public void LogicThrowEx(int num1)
        {
            int result = num1 / 0;
        }
        public void LogicEx(int num1, int num2)
        {
            try
            {
                int result = num1 / num2;
            }
            catch (OverflowException oEx)
            {
                Console.WriteLine($"Ocurrio un error: {oEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("esto es un finally de LogicEx");
            }
        }
    }
}
