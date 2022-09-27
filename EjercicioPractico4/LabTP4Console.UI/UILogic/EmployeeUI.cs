using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabTP4.Entities;
using LabTP4.Logic;

namespace LabTP4Console.UI
{
    class EmployeeUI : BaseUI<Employee>
    {
        public override void Alta()
        {
            throw new NotImplementedException();
        }

        public override void Baja()
        {
            throw new NotImplementedException();
        }

        public override void Listar()
        {
            Console.WriteLine("******Listado de Empleados******");

            try
            {
                List<Employee> list = new List<Employee>();
                ILogic<Employee> el = new EmployeeLogic();
                var employees = el.GetAll();
                foreach (var item in employees)
                {
                    Console.WriteLine($"{item.FirstName} - {item.LastName} - {item.Address}");
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"la excepcion {ex.Message}") ;
            }
        }

        public override void Modificacion()
        {
            throw new NotImplementedException();
        }
    }
}
