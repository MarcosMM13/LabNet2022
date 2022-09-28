using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabTP4.Entities;
using LabTP4.Logic;

namespace LabTP4Console.UI
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

            do
            {
                Console.Clear();
                Console.WriteLine("*******NORTHWIND*******");
                ShowMenuGeneral();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        EmployeeUI employeeUI = new EmployeeUI();
                        employeeUI.Menu();
                        break;
                    case "2":
                        RegionUI regionUI = new RegionUI();
                        regionUI.Menu();
                        break;
                    case "3":
                        TerritoriesUI territoriesUI = new TerritoriesUI();
                        territoriesUI.Menu();
                        break;
                    case "4":
                        OrderUI orderUI = new OrderUI();
                        orderUI.Menu();
                        break;
                    case "5":
                        ProductUI productUI = new ProductUI();
                        productUI.Menu();
                        break;
                    case "6":
                        SuppliersUI suppliersUI = new SuppliersUI();
                        suppliersUI.Menu();
                        break;
                    case "7":
                        CategoryUI categoryUI = new CategoryUI();
                        categoryUI.Menu();
                        break;
                    case "8":
                        About();
                        break;
                    case "9":
                        break;

                    default:
                        Console.WriteLine("Opcion No Valida");
                        break;
                }
            } while (option != "9");

            Console.ReadKey();
        }
        private static void ShowMenuGeneral()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Empleados");
            sb.AppendLine("2. Region");
            sb.AppendLine("3. Territorios");
            sb.AppendLine("4. Ordenes");
            sb.AppendLine("5. Productos");
            sb.AppendLine("6. Suplementos");
            sb.AppendLine("7. Categorias");
            sb.AppendLine("8. Acerca De");
            sb.AppendLine("9. Salir");
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
