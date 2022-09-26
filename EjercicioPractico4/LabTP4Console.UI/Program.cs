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
            //Console.WriteLine("Esto es Empleado");
            ////EmployeeLogic el = new EmployeeLogic();
            //ILogic<Employee> el = new EmployeeLogic();
            //var employees = el.GetAll();

            //foreach (var item in employees)
            //{
            //    Console.WriteLine($"{item.FirstName} - {item.LastName} - {item.Address} - {item.City}");
            //}


            Console.WriteLine("");
            Console.WriteLine("*******************************************");

            Console.WriteLine("Esto es Region");
            //RegionLogic rl = new RegionLogic();
            Region r = new Region();
            ILogic<Region> rl = new RegionLogic();
         
            int? idRegion = r.RegionID;
            string descRegion = r.RegionDescription;

            //try
            //{
            //    Console.WriteLine("Ingrese el Id de la Region:");
            //    idRegion = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Ingrese la descripcion:");
            //    descRegion = Console.ReadLine();

            //    rl.Add(new Region
            //    {
            //        RegionID = idRegion,
            //        RegionDescription = descRegion
            //    });
            //    Console.WriteLine("Se guardo registro con exito!");

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"{ex.Message}");
            //}

            //Console.WriteLine("Aca se borra una Region");
            //try
            //{                
            //    foreach (var item in rl.GetAll())
            //    {
            //        Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
            //    }

            //    Console.WriteLine("Ingrese el id de la region que quiere borrar");
            //    idRegion = int.Parse(Console.ReadLine());
            //    rl.Delete(idRegion);
            //    Console.WriteLine("se borro con exito");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"{ex.Message}");
            //}            

            Console.WriteLine("Esto es actualizar la region");

            try
            {
                foreach (var item in rl.GetAll())
                {
                    Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
                }

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


            var region = rl.GetAll();
            foreach (var item in region)
            {
                Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
            }
            Console.WriteLine();



            Console.WriteLine("");
            Console.WriteLine("*******************************************");

            //Console.WriteLine("Esto es Territorio");
            ////RegionLogic rl = new RegionLogic();
            //ILogic<Territory> tl = new TerritoriesLogic();
            //var territorio = tl.GetAll();

            //foreach (var item in territorio)
            //{
            //    Console.WriteLine($"{item.TerritoryID} - {item.RegionID} - {item.TerritoryDescription}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("");
            //Console.WriteLine("*******************************************");  

            Console.ReadKey();
        }
    }
}
