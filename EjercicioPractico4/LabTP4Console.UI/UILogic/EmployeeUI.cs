using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabTP4.Entities;
using LabTP4.Logic;

namespace LabTP4Console.UI
{
    class EmployeeUI : BaseUI<Employee>
    {
        public override void Alta()
        {
            throw new NotImplementedException();
        }

        public override void Baja()
        {
            throw new NotImplementedException();
        }
        public override void Modificacion()
        {
            throw new NotImplementedException();
        }

        public override void Listar()
        {
            Console.WriteLine("******Listado de Empleados******");

            try
            {
                List<Employee> list = new List<Employee>();
                ILogic<Employee> el = new EmployeeLogic();
                var employees = el.GetAll();
                foreach (var item in employees)
                {
                    Console.WriteLine($"{item.FirstName} - {item.LastName} - {item.Address}");
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"la excepcion {ex.Message}") ;
            }
        }
        public override void Menu()
        {
            string option = "";            

            do
            {
                Console.Clear();
                Console.WriteLine("*******Menu de Empleados*******");
                ShowMenu();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Alta();
                        Console.ReadKey();
                        break;
                    case "2":
                        Baja();
                        Console.ReadKey();
                        break;
                    case "3":
                        Modificacion();
                        Console.ReadKey();
                        break;
                    case "4":
                       Listar();
                        Console.ReadKey();
                        break;
                    case "5":
                        break;

                    default:
                        Console.WriteLine("Opcion No Valida");
                        break;
                }
            } while (option != "5");

            Console.ReadKey();
        }
        public override void ShowMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Alta de Empleados");
            sb.AppendLine("2. Baja de Empleados");
            sb.AppendLine("3. Modificacion de Empleados");
            sb.AppendLine("4. Ver Listado de Empleados");
            sb.AppendLine("5. Salir");
            sb.Append("Seleccione una Opcion");

            Console.WriteLine(sb.ToString());
        }
    }
}
