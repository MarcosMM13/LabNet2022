using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabTP4.Entities;


namespace LabTP4.Logic.Logic
{
    public class OrderLogic : BaseLogic<Orders>
    {
        public override void Add(Orders newObj)
        {
            _context.Orders.Add(newObj);

            _context.SaveChanges();
        }

        public override void Delete(int id)
        {
            var orderEliminar = _context.Orders.Find(id);

            _context.Orders.Remove(orderEliminar);

            _context.SaveChanges();
        }

        public override List<Orders> GetAll()
        {
            return _context.Orders.ToList();
        }

        public override Orders GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Orders obj)
        {
            try
            {
                var orderUpdate = _context.Orders.Find(obj.OrderID);
                orderUpdate.Order_Details = orderUpdate.Order_Details;
                orderUpdate.OrderDate = orderUpdate.OrderDate;
                orderUpdate.CustomerID = orderUpdate.CustomerID;
                orderUpdate.EmployeeID = orderUpdate.EmployeeID;
                orderUpdate.OrderDate = orderUpdate.OrderDate;
                orderUpdate.RequiredDate = orderUpdate.RequiredDate;
                orderUpdate.ShippedDate = orderUpdate.ShippedDate;
                orderUpdate.ShipVia = orderUpdate.ShipVia;
                orderUpdate.Freight = orderUpdate.Freight;
                orderUpdate.ShipName = orderUpdate.ShipName;
                orderUpdate.ShipAddress = orderUpdate.ShipAddress;
                orderUpdate.ShipCity = orderUpdate.ShipCity;
                orderUpdate.ShipCountry = orderUpdate.ShipCountry;
                orderUpdate.ShipRegion = orderUpdate.ShipRegion;
                orderUpdate.ShipPostalCode = orderUpdate.ShipPostalCode;
            }
            catch (Exception ex)
            {

                throw ex;
            }


            _context.SaveChanges();
        }
    }
}
