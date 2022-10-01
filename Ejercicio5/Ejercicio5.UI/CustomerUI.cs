using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio5.Entities;
using Ejercicio5.Logic;

namespace Ejercicio5.UI
{
    public class CustomerUI
    {
        public void Ejercicio1()
        {
            CustomerLogic logic = new CustomerLogic();
            var customers = logic.Listar();

            foreach (var item in customers)
            {
                Console.WriteLine();
            Console.WriteLine($"{item.CustomerID} -- {item.CompanyName} -- {item.ContactName} -- {item.ContactTitle} -- {item.Address} --" +
                $" {item.City} -- {item.Region} -- {item.PostalCode} -- {item.Phone} -- {item.Fax}");
                Console.WriteLine("********************************************************************************************************");
            }

           
        }
    }
}
/*[CustomerID]
  [CompanyName]
  [ContactName]
  [ContactTitle]
  [Address]
  [City]
  [Region]
  [PostalCode]
  [Country]
  [Phone]
  [Fax]*/


