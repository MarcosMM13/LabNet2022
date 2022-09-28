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
            Orders logic = new Orders();
            ILogic<Orders> iLogic = new OrderLogic();
            int? idOrden = logic.OrderID;
            string shipNombre = logic.ShipName;
            string shipCiudad = logic.ShipCity;
           

            try
            {
                Console.WriteLine("Ingrese el Id de la nueva Orden:");
                idOrden = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre del tramportista:");
                shipNombre = Console.ReadLine();
                Console.WriteLine("Ingrese la ciudad del tramportista:");
                shipCiudad = Console.ReadLine();

                iLogic.Add(new Orders
                {
                    OrderID = (int)idOrden,
                    ShipName = shipNombre,
                    ShipCity = shipCiudad
                });
                Console.WriteLine("Se guardo registro con exito!");
                Console.WriteLine("Asi queda actualizada la lista de ordenes:");
                Listar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        public override void Baja()
        {
            Console.WriteLine("Listado de Registros Actualizado");
            Orders logic = new Orders();
            ILogic<Orders> iLogic = new OrderLogic();
            int? idOrden = logic.OrderID;
          

            try
            {
                Console.WriteLine("Ingrese el id de la orden que desea borrar");
                idOrden = int.Parse(Console.ReadLine());
                iLogic.Delete((int)idOrden);
                Console.WriteLine("Se borro el registro con exito");
                Console.WriteLine("Asi queda actualizada la lista de ordenes:");
                Listar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
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
                    Console.WriteLine($"{item.OrderID} - {item.ShipName} - {item.ShipCity}");
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
            Console.WriteLine("Listado de Registros Actualizado");
            Orders logic = new Orders();
            ILogic<Orders> iLogic = new OrderLogic();
            int? idOrden = logic.OrderID;
            string shipNombre = logic.ShipName;
            string shipCiudad = logic.ShipCity;
          

            try
            {
                Console.WriteLine("Modifique el Id de la Region:");
                idOrden = int.Parse(Console.ReadLine());
                Console.WriteLine("Modifique el nombre del tramportista:");
                shipNombre = Console.ReadLine();
                Console.WriteLine("Modifique la ciudad del tramportista:");
                shipCiudad = Console.ReadLine();

                if (idOrden != null)
                {
                    iLogic.Update(new Orders
                    {
                        OrderID = (int)idOrden,
                        ShipName = shipNombre,
                        ShipCity = shipCiudad
                    });
                }
                Console.WriteLine("Se actualizo con exito!");
                Console.WriteLine("Asi queda actualizada la lista de ordenes:");
                Listar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }           
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
            sb.AppendLine("1. Ver Listado de Ordenes");
            sb.AppendLine("2. Salir");
            sb.Append("Seleccione una Opcion");

            Console.WriteLine(sb.ToString());
        }
    }
}
