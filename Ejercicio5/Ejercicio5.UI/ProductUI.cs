using Ejercicio5.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.UI
{
  public  class ProductUI
    {
        public void Ejercicio2()
        {
            ProductLogic logic = new ProductLogic();
            var products = logic.Listar();

            var query = products.Where(p => p.UnitsInStock == 0);
           
            var query1 = from product in products
                         where product.UnitsInStock == 0
                         select product;

            foreach (var item in query)
            {
                Console.WriteLine();
                Console.WriteLine($"{item.ProductName}");
                Console.WriteLine("********************************************************************************************************");
            }
            
            foreach (var item in query1)
            {
                Console.WriteLine();
                Console.WriteLine($"{item.ProductName}");
                Console.WriteLine("********************************************************************************************************");
            }


        }
    }
}/*[ProductID]
   [ProductName]
   [SupplierID]
   [CategoryID]
   [QuantityPerUnit]
   [UnitPrice]
   [UnitsInStock]
   [UnitsOnOrder]
   [ReorderLevel]
   [Discontinued]*/
