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
            Listar();
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
            Listar();            
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

                Console.WriteLine($"{ex.Message}");
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
            Listar();
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
    }
}


