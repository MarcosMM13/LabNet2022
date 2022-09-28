using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabTP4.Entities;
using LabTP4.Logic;

namespace LabTP4Console.UI
{
    class ProductUI : BaseUI<Product>
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
            Console.WriteLine("******Listado de Productos******");
            try
            {
                ILogic<Product> tl = new ProducLogic();
                var territorio = tl.GetAll();

                foreach (var item in territorio)
                {
                    Console.WriteLine($"{item.ProductID} - {item.ProductName} - ${item.UnitPrice}");
                }
                Console.WriteLine("");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override void Menu()
        {
            string option = "";

            do
            {
                Console.Clear();
                Console.WriteLine("*******Menu de Productos*******");
                ShowMenu();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Listar();
                        Console.ReadKey();
                        break;
                    case "2":
                        break;

                    default:
                        Console.WriteLine("Opcion No Valida");
                        break;
                }
            } while (option != "2");

            Console.ReadKey();
        }
        public override void ShowMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Ver Listado de Productos");
            sb.AppendLine("2. Salir");
            sb.Append("Seleccione una Opcion");

            Console.WriteLine(sb.ToString());
        }
    }
}
