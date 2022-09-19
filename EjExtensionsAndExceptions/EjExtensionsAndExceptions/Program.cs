using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjExtensionsAndExceptions.Exceptions;
using EjExtensionsAndExceptions.Extensions;


namespace EjExtensionsAndExceptions
{
    class Program
    {
        private static int _num1;
        private static int _num2;
        private static double _result;
        private static string _sNum;

        static void Main(string[] args)
        {
            Menu();

            Console.WriteLine("");
            Console.WriteLine("***********************************");
            Console.WriteLine("El programa termino, ya puedo salir a jugar? =D");
            Console.ReadKey();
        }

        #region Methods
        private static void DivideByZero()
        {
            try
            {
                Console.WriteLine("Esta es una excepcion para mostrar una division por cero");
                Console.WriteLine("ingrese un valor");
                _sNum = Console.ReadLine();
                NumValidation();
                _num1 = int.Parse(_sNum);
                _result = _num1.Divide();

            }
            catch
            {
                ExceptionsMethods.DivideByZeroEx(_num1);
            }

            Console.ReadKey();
        }
        private static void DivideNumbers()
        {
            try
            {
                Console.WriteLine("Esto es una demostracion de una excepcion entre dos numeros");
                Console.WriteLine("ingrese el divisor");
                _sNum = Console.ReadLine();
                NumValidation();
                _num1 = int.Parse(_sNum);                

                Console.WriteLine("ingrese el dividendo");
                _sNum = Console.ReadLine();
                NumValidation();
                _num2 = int.Parse(_sNum);

                _result = _num1.Divide(_num2);

                Console.WriteLine($"El resultado es {_result}");
            }
            catch
            {
                ExceptionsMethods.DivideNumbersEx(_num1, _num2);
            }
            finally
            {
                Console.WriteLine("esto es un finally de dividir dos numeros");
            }
            Console.ReadKey();
        }
        private static void LogicEx()
        {
            Console.WriteLine("Aca nos arroja una excepcion por codigo");
            Logic logic = new Logic();

            try
            {
                logic.LogicThrowEx(10);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"error {ex.Message}");
            }

            Console.ReadKey();
        }
        private static void CustomEx()
        {
            ExceptionsMethods.ThrowCustomMethod();

            Console.ReadKey();
        }
        private static void NumValidation()
        {
            ValidateMethods.NegativeNumberVal(_num1);
            ValidateMethods.NullNumberVal(_num1);
            ValidateMethods.CharVal(_sNum);
        }
        private static void Menu()
        {
            string option = "";

            do
            {
                Console.Clear();
                Console.WriteLine("*******Manejo de Excepciones - Extensiones - UnitTest*******");
                ShowMenu();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        DivideByZero();
                        break;
                    case "2":
                        DivideNumbers();
                        break;
                    case "3":
                        LogicEx();
                        break;
                    case "4":
                        CustomEx();
                        break;
                    case "5":
                        About();
                        break;
                    case "6":
                        break;

                    default:
                        Console.WriteLine("Opcion No Valida");
                        break;
                }
            } while (option != "6");

            Console.ReadKey();
        }
        private static void ShowMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Ejercicio 1");
            sb.AppendLine("2. Ejercicio 2");
            sb.AppendLine("3. Ejercicio 3");
            sb.AppendLine("4. Ejercicio 4");
            sb.AppendLine("5. Acerca De");
            sb.AppendLine("6. Salir");
            sb.Append("Seleccione una Opcion");

            Console.WriteLine(sb.ToString());
        }
        private static void About()
        {
            Console.WriteLine("Nombre: Marcos Mateos");
            Console.WriteLine("Presiona para continuar.");
            Console.ReadKey();
        }

        #endregion
    }
}
