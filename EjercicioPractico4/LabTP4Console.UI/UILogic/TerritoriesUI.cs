using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabTP4.Entities;
using LabTP4.Logic;

namespace LabTP4Console.UI
{
    class TerritoriesUI : BaseUI<Territory>
    {
        public override void Alta()
        {
            Territory t = new Territory();
            ILogic<Territory> tl = new TerritoriesLogic();
           
            string idTerritorio = t.TerritoryID;
            string descTerritorio = t.TerritoryDescription;
            int? idRegion = t.RegionID;

            try
            {
                Console.WriteLine("Ingrese el Id de la Region:");
                idRegion = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Id del Territorio:");
                idTerritorio = Console.ReadLine();
                Console.WriteLine("Ingrese la descripcion:");
                descTerritorio = Console.ReadLine();

                tl.Add(new Territory
                {
                    TerritoryID = idTerritorio,
                    TerritoryDescription = descTerritorio,
                    RegionID = (int)idRegion

                });
                Console.WriteLine("Se guardo registro con exito!");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}");
            }

            Console.WriteLine();
            Listar();
            Console.WriteLine("");
        }
        public override void Baja()
        {
            Territory t = new Territory();
            ILogic<Territory> tl = new TerritoriesLogic();
                     
            string idTerritorio = t.TerritoryID;
            string descTerritorio = t.TerritoryDescription;
            int? idRegion = t.RegionID;
         
            try
            {

                Console.WriteLine("Ingrese el id de la region que quiere borrar");
                idRegion = int.Parse(Console.ReadLine());
                //tl.Delete(idTerritorio);
                Console.WriteLine("se borro con exito");
                Console.WriteLine("");


            }
            catch (Exception ex)
            {

                Console.WriteLine($"No se puede eliminar el registro seleccionado por" +
                   $"contener relacion con los Empleados cargados.");
                Console.WriteLine("Ver listados de registros y seleccione otra Id para eliminar.");
                Console.WriteLine($"Descripcion del error: {ex.Message}");
            }

            Console.WriteLine();
            Listar();
            Console.WriteLine("");
        }
        public override void Listar()
        {
            Console.WriteLine("******Listado de Territorio******");
            try
            {
                ILogic<Territory> tl = new TerritoriesLogic();
                var territorio = tl.GetAll();

                foreach (var item in territorio)
                {
                    Console.WriteLine($"{item.TerritoryID} - {item.RegionID} - {item.TerritoryDescription}");
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
            Territory t = new Territory();
            ILogic<Territory> tl = new TerritoriesLogic();
           
            string idTerritorio = t.TerritoryID;
            string descTerritorio = t.TerritoryDescription;
            int? idRegion = t.RegionID;
            
            try
            {
                Console.WriteLine();
                Console.WriteLine("Modifique el Id de la Region:");
                idRegion = int.Parse(Console.ReadLine());
                Console.WriteLine("Modifique el Id del Territorio:");
                idTerritorio = Console.ReadLine();
                Console.WriteLine("Modifique la descripcion:");
                descTerritorio = Console.ReadLine();

                if (idTerritorio != null)
                {
                    tl.Update(new Territory
                    {
                        TerritoryID = idTerritorio,
                        TerritoryDescription = descTerritorio,
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
            Console.WriteLine("");
        }
        public override void Menu()
        {
            string option = "";
            
            do
            {
                Console.Clear();
                Console.WriteLine("*******Territorios*******");
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
            sb.AppendLine("1. Alta de Territorio");
            sb.AppendLine("2. Baja de Territorio");
            sb.AppendLine("3. Modificacion de Territorios");
            sb.AppendLine("4. Ver Listado de Territorios");
            sb.AppendLine("5. Salir");
            sb.Append("Seleccione una Opcion");

            Console.WriteLine(sb.ToString());
        }
    }
}


