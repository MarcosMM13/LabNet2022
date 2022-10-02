using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio5.Logic;
using Ejercicio5.Entities;

namespace Ejercicio5.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

            Console.ReadKey();
        }
        private static void Menu()
        {
            string option = "";
            EjerciciosLinq e = new EjerciciosLinq();

            do
            {
                Console.Clear();
                Console.WriteLine("*******PRACTICA LINQ*******");
                ShowMenuGeneral();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        e.Ejercicio1();
                        Console.ReadKey();
                        break;
                    case "2":
                        e.Ejercicio2();
                        Console.ReadKey();
                        break;
                    case "3":
                        e.Ejercicio3();
                        Console.ReadKey();
                        break;
                    case "4":
                        e.Ejercicio4();
                        Console.ReadKey();
                        break;
                    case "5":
                        e.Ejercicio5();
                        Console.ReadKey();
                        break;
                    case "6":
                        e.Ejercicio6();
                        Console.ReadKey();
                        break;
                    case "7":
                        e.Ejercicio7();
                        Console.ReadKey();
                        break;
                    case "8":
                        e.Ejercicio8();
                        Console.ReadKey();
                        break;
                    case "9":
                        e.Ejercicio9();
                        Console.ReadKey();
                        break;
                    case "10":
                        e.Ejercicio10();
                        Console.ReadKey();
                        break;
                    case "11":
                        e.Ejercicio11();
                        Console.ReadKey();
                        break;
                    case "12":
                        e.Ejercicio12();
                        Console.ReadKey();
                        break;
                    case "13":
                        e.Ejercicio13();
                        Console.ReadKey();
                        break;                   
                    case "14":
                        About();
                        break;
                    case "15":
                        break;

                    default:
                        Console.WriteLine("Opcion No Valida");
                        break;
                }
            } while (option != "15");

            Console.ReadKey();
        }
        private static void ShowMenuGeneral()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Ejercicio 1");
            sb.AppendLine("2. Ejercicio 2");
            sb.AppendLine("3. Ejercicio 3");
            sb.AppendLine("4. Ejercicio 4");
            sb.AppendLine("5. Ejercicio 5");
            sb.AppendLine("6. Ejercicio 6");
            sb.AppendLine("7. Ejercicio 7");
            sb.AppendLine("8. Ejercicio 8");
            sb.AppendLine("9. Ejercicio 9");
            sb.AppendLine("10. Ejercicio 10");
            sb.AppendLine("11. Ejercicio 11");
            sb.AppendLine("12. Ejercicio 12");
            sb.AppendLine("13. Ejercicio 13");
            sb.AppendLine("14. Acerca De");
            sb.AppendLine("15. Salir");
            sb.Append("Seleccione una Opcion");

            Console.WriteLine(sb.ToString());
        }
        private static void About()
        {
            Console.WriteLine("Nombre: Marcos Mateos");
            Console.WriteLine("Presiona para continuar.");
            Console.ReadKey();
        }
    }
}
