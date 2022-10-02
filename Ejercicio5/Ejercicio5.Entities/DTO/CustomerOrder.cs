using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Entities.DTO
{
    public class CustomerOrder
    {
        public string CustomerID { get; set; }
        public int OrderID { get; set; }
        public string ContactName { get; set; }
        public string Region { get; set; }
        public DateTime? OrderDate { get; set; }

        public int CantOrdenes { get; set; }
    }
}
