using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio5.Entities;

namespace Ejercicio5.Logic.Linq
{
    public class ProductLinq: ProductLogic
    {
        public IEnumerable<Product> ProductoSinStock()
        {            
            ProductLogic logic = new ProductLogic();
            var products = logic.Listar();

            var query = products.Where(p => p.UnitsInStock == 0);

            var query1 = from product in products
                         where product.UnitsInStock == 0
                         select product;

            return query;
        }

        public IEnumerable<Product> ProductoConStock()
        {
        ProductLogic logic = new ProductLogic();
        var products = logic.Listar();

        var query = products.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3);

        var query1 = from product in products
                     where product.UnitsInStock != 0
                     && product.UnitPrice > 3
                     select product;

            return query;
        }

    }
}
