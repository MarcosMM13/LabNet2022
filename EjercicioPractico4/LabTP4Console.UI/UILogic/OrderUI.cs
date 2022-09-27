using LabTP4.Entities;
using LabTP4.Logic;
using LabTP4.Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP4Console.UI
{
    class OrderUI : BaseUI<Orders>
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
            Console.WriteLine("******Listado de Ordenes******");
            try
            {
                ILogic<Orders> ol = new OrderLogic();
                var territorio = ol.GetAll();

                foreach (var item in territorio)
                {
                    Console.WriteLine($"{item.OrderID} - {item.OrderDate} - {item.Order_Details}");
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
                Console.WriteLine("*******Menu de Ordenes*******");
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
            sb.AppendLine("1. Alta de Ordenes");
            sb.AppendLine("2. Baja de Ordenes");
            sb.AppendLine("3. Modificacion de Ordenes");
            sb.AppendLine("4. Ver Listado de Ordenes");
            sb.AppendLine("5. Salir");
            sb.Append("Seleccione una Opcion");

            Console.WriteLine(sb.ToString());
        }
    }
}
