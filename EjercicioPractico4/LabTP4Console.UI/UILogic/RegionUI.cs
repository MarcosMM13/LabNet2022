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
                Console.WriteLine("Asi queda actualizada la lista de regiones:");
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
            Region r = new Region();
            ILogic<Region> rl = new RegionLogic();
            int? idRegion = r.RegionID;
            string descRegion = r.RegionDescription;
           

            try
            {                
                Console.WriteLine("Ingrese el id de la region que quiere borrar");
                idRegion = int.Parse(Console.ReadLine());
                rl.Delete((int)idRegion);
                Console.WriteLine("Se borro con exito");
                Console.WriteLine("Asi queda actualizada la lista de regiones:");
                Listar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se puede eliminar el registro seleccionado por" +
                   $"contener relacion con los Empleados cargados.");
                Console.WriteLine("Ver listados de registros y seleccione otra Id para eliminar.");
                Console.WriteLine($"Descripcion del error: {ex.Message}");
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
           
            sb.AppendLine("1. Ver Listado de Regiones");
            sb.AppendLine("2. Salir");
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

    }
}
