using LabTP4.Entities;
using LabTP4.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP4Console.UI
{
    class SuppliersUI : BaseUI<Supplier>
    {
        public override void Alta()
        {
            throw new NotImplementedException();
        }

        public override void Baja()
        {
            throw new NotImplementedException();
        }

        public override void Listar()
        {
            Console.WriteLine("******Listado de Suplementos******");
            try
            {
                ILogic<Supplier> sl = new SuppliersLogic();
                var territorio = sl.GetAll();

                foreach (var item in territorio)
                {
                    Console.WriteLine($"{item.SupplierID} - {item.ContactName} - {item.Address}");
                }
                Console.WriteLine("");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override void Modificacion()
        {
            throw new NotImplementedException();
        }
        public override void Menu()
        {
            string option = "";

            do
            {
                Console.Clear();
                Console.WriteLine("*******Menu de Suplementos" +
                    "*******");
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
            sb.AppendLine("1. Alta de Suplementos");
            sb.AppendLine("2. Baja de Suplementos");
            sb.AppendLine("3. Modificacion de Suplementos");
            sb.AppendLine("4. Ver Listado de Suplementos");
            sb.AppendLine("5. Salir");
            sb.Append("Seleccione una Opcion");

            Console.WriteLine(sb.ToString());
        }
    }
}
