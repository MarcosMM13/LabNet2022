using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabTP4.Entities;

namespace LabTP4.Logic
{
    public class EmployeeLogic : BaseLogic, ILogic<Employee>
    {
        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
                     
        }
        public int? GetId(int? id)
        {
            try
            {
                return id;
            }
            catch
            {
                return null;
            }
        }
        public void Add(Employee newEmployee)
        {
            
            _context.Employees.Add(newEmployee);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employeEliminar = _context.Employees.Find(id);
            _context.Employees.Remove(employeEliminar);

            _context.SaveChanges();

        }

        public void Update(Employee employee)
        {
            var employeUpdate = _context.Employees.Find(employee.EmployeeID);

            try
            {
                employeUpdate.LastName = employeUpdate.LastName;
                employeUpdate.FirstName = employeUpdate.FirstName;
                employeUpdate.Title = employeUpdate.Title;
                employeUpdate.TitleOfCourtesy = employeUpdate.TitleOfCourtesy;
                employeUpdate.BirthDate = employeUpdate.BirthDate;
                employeUpdate.HireDate = employeUpdate.HireDate;
                employeUpdate.Address = employeUpdate.Address;
                employeUpdate.City = employeUpdate.City;
                employeUpdate.Region = employeUpdate.Region;
                employeUpdate.PostalCode = employeUpdate.PostalCode;
                employeUpdate.Country = employeUpdate.Country;
                employeUpdate.HomePhone = employeUpdate.HomePhone;
                employeUpdate.Extension = employeUpdate.Extension;
                employeUpdate.Photo = employeUpdate.Photo;
                employeUpdate.Notes = employeUpdate.Notes;
                employeUpdate.ReportsTo = employeUpdate.ReportsTo;
                employeUpdate.PhotoPath = employeUpdate.PhotoPath;
               
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
