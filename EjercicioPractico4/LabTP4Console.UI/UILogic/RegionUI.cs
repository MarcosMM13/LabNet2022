using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabTP4.Entities;
using LabTP4.Logic;

namespace LabTP4Console.UI
{
    class RegionUI : BaseUI<Region>
    {
        public override void Alta()
        {
            Region r = new Region();
            ILogic<Region> rl = new RegionLogic();
            int? idRegion = r.RegionID;
            string descRegion = r.RegionDescription;
            Listar();

            try
            {
                Console.WriteLine("Ingrese el Id de la Region:");
                idRegion = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la descripcion:");
                descRegion = Console.ReadLine();

                rl.Add(new Region
                {
                    RegionID = (int)idRegion,
                    RegionDescription = descRegion
                });
                Console.WriteLine("Se guardo registro con exito!");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        public override void Baja()
        {
            Console.WriteLine("Aca se borra una Region");
            Region r = new Region();
            ILogic<Region> rl = new RegionLogic();
            int? idRegion = r.RegionID;
            string descRegion = r.RegionDescription;
            Listar();

            try
            {                
                Console.WriteLine("Ingrese el id de la region que quiere borrar");
                idRegion = int.Parse(Console.ReadLine());
                rl.Delete((int)idRegion);
                Console.WriteLine("se borro con exito");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        public override void Listar()
        {
            Console.WriteLine("******Listado de Regiones******");
            try
            {
                ILogic<Region> rl = new RegionLogic();
                var territorio = rl.GetAll();

                foreach (var item in territorio)
                {
                    Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
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
            Console.WriteLine("Esto es actualizar la region");
            Region r = new Region();
            ILogic<Region> rl = new RegionLogic();
            int? idRegion = r.RegionID;
            string descRegion = r.RegionDescription;
            Listar();           

            try
            {      
                Console.WriteLine("Modifique el Id de la Region:");
                idRegion = int.Parse(Console.ReadLine());
                Console.WriteLine("Modifique la descripcion:");
                descRegion = Console.ReadLine();

                if (idRegion != null)
                {
                    rl.Update(new Region
                    {
                        RegionDescription = descRegion,
                        RegionID = (int)idRegion
                    });
                }
                Console.WriteLine("Se actualizo con exito!");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}");
            }

            Console.WriteLine();
            Listar();
            Console.WriteLine();
        }

        public override void ShowMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Alta de Region");
            sb.AppendLine("2. Baja de Region");
            sb.AppendLine("3. Modificacion de Region");
            sb.AppendLine("4. Ver Listado de Regiones");
            sb.AppendLine("5. Salir");
            sb.Append("Seleccione una Opcion");

            Console.WriteLine(sb.ToString());
        }
        public override void Menu()
        {
            string option = "";
          
            do
            {
                Console.Clear();
                Console.WriteLine("*******Regiones*******");
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

    }
}
