using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio5.Entities;
using Ejercicio5.Entities.DTO;

namespace Ejercicio5.Logic.Linq
{
   public class CustomerLinq : CustomerLogic
    {
        public IEnumerable<Customer> ObjetoCustomer()
        {
            CustomerLogic logic = new CustomerLogic();
            var customers = logic.Listar();

            return customers;
        }
        public IEnumerable<Customer> RegionWA()
        {
            CustomerLogic logic = new CustomerLogic();
            var customers = logic.Listar();

            var query = customers.Where(c => c.Region == "WA");

            var query1 = from customer in customers
                         where customer.Region == "WA"
                         select customer;

            return query;
        }
        
    }
}
