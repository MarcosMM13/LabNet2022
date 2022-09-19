using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjExtensionsAndExceptions.Extensions;

namespace EjExtensionsAndExceptions.Exceptions
{
    public static class ExceptionsMethods
    {
        public static void ThrowCustomMethod()
        {
            try
            {
                throw new CustomException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Capturo la excepcion : {ex.Message}");
            }
        }
        public static void DivideByZeroEx(int num1)
        {
            try
            {
                int result = num1 / 0;
            }
            catch (DivideByZeroException dEx)
            {
                Console.WriteLine($"Error: {dEx.Message}");
            }
            catch (FormatException fEx)
            {
                Console.WriteLine($"la excepcion es : {fEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"La excepcion es: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Aqui finaliza la division por cero!");
            }
        }
        public static void DivideNumbersEx(int num1, int num2)
        {
            try
            {
                {
                  double  result = num1 / num2;
                }
            }
            catch (DivideByZeroException dEx)
            {
                Console.WriteLine($"Wey ya! en serio? aca esta tu error: {dEx.Message}");
            }
            catch (FormatException fEx)
            {
                Console.WriteLine($"la excepcion es : {fEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"La excepcion es: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("No se si esta bien, pero aca va el final!");
            }

        }
    }
}
