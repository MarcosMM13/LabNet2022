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

            //ProducLogic pl = new ProducLogic();
            ILogic<Product> pl = new ProducLogic();
            var products = pl.GetAll();

            foreach (var item in products)
            {
                Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            }

            Console.WriteLine("");
            Console.WriteLine("*******************************************");

            RegionLogic rl = new RegionLogic();
            //ILogic<Region> rl = new RegionLogic();
            var products2 = rl.GetAll();

            foreach (var item in products2)
            {
                Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
            }
            Console.WriteLine();
            //rl.Add(new Region
            //{
            //    RegionID = 10,
            //    RegionDescription = "Montañas"

            //});


            //rl.Delete(10);
            //Console.WriteLine("se borro con exito");

            rl.Update(new Region
            {
                RegionDescription = "Nueva Descripcion",
                RegionID = 10
            });

            foreach (var item in products2)
            {
                Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
            }



            Console.ReadKey();
        }
    }
}
