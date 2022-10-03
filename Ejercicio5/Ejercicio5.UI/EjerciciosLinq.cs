using Ejercicio5.Entities;
using Ejercicio5.Entities.DTO;
using Ejercicio5.Logic;
using Ejercicio5.Logic.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.UI
{
    public class EjerciciosLinq
    {
        public void Ejercicio1()
        {
            CustomerLinq customerLinq = new CustomerLinq();
            var query = customerLinq.ObjetoCustomer();

            Console.WriteLine("Query Que devuelve Customer");
            foreach (var item in query)
            {
                Console.WriteLine();
                Console.WriteLine($"{item.CustomerID} -- {item.CompanyName} -- {item.ContactName} -- {item.ContactTitle} -- {item.Address} --" +
                    $" {item.City} -- {item.Region} -- {item.PostalCode} -- {item.Phone} -- {item.Fax}");
                Console.WriteLine("********************************************************************************************************");
            }
        }
        public void Ejercicio2()
        {
            ProductLinq productLinq = new ProductLinq();
            var query = productLinq.ProductoSinStock();

            Console.WriteLine("Query Que devuelve Productos sin Stock");
            foreach (var item in query)
            {
                Console.WriteLine();
                Console.WriteLine($"{item.ProductName}");
                Console.WriteLine("********************************************************************************************************");
            }
        }
        public void Ejercicio3()
        {
            ProductLinq productLinq = new ProductLinq();
            var query = productLinq.ProductoConStockMasDe3();

            Console.WriteLine("Query Que devuelve todos los productos que tienen stock y que cuestan mas de 3");
            foreach (var item in query)
            {
                Console.WriteLine();
                Console.WriteLine($"{item.ProductName}");
                Console.WriteLine("********************************************************************************************************");
            }
        }
        public void Ejercicio4()
        {
            CustomerLinq customerLinq = new CustomerLinq();
            var query = customerLinq.RegionWA();

            Console.WriteLine("Query Que devuelve todos los customers de la Región WA");
            foreach (var item in query)
            {
                Console.WriteLine();
                Console.WriteLine($"{item.CustomerID} -- {item.CompanyName} -- {item.ContactName} -- {item.ContactTitle} -- {item.Address} --" +
                    $" {item.City} -- {item.Region} -- {item.PostalCode} -- {item.Phone} -- {item.Fax}");
                Console.WriteLine("********************************************************************************************************");
            }
        }
        public void Ejercicio5()
        {
            ProductLogic logic = new ProductLogic();
            var products = logic.Listar();

            Console.WriteLine("Query para devolver el primer elemento o nulo de una lista de productos donde el ID de " +
                "producto sea igual a 789");
            var query = products.Where(p => p.ProductID == 789).FirstOrDefault();
            Console.WriteLine($"Esto es el first or default - {query}");

        }
        public void Ejercicio6()
        {
            CustomerLogic logic = new CustomerLogic();
            var customers = logic.Listar();
            var query = customers.ToList();

            Console.WriteLine("Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en" +
                    " Minuscula.");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.ContactName.ToLower()} -- {item.ContactName.ToUpper()}");
            }
        }
        public void Ejercicio7()
        {
            CustomerLogic logic = new CustomerLogic();
            var customers = logic.Listar();
            OrderLogic orderLogic = new OrderLogic();
            var orders = orderLogic.Listar();

            DateTime date = new DateTime(1997, 01, 01);

            var query = from customer in customers
                        join order in orders
                        on customer.CustomerID equals order.CustomerID
                        where order.OrderDate > date && customer.Region == "WA"
                        select new CustomerOrder
                        {
                            CustomerID = customer.CustomerID,
                            ContactName = customer.ContactName,
                            OrderID = order.OrderID
                        };

            Console.WriteLine("Query para devolver Join entre Customers y Orders donde los customers sean de la "
                        +" Región WA y la fecha de orden sea mayor a 1 / 1 / 1997.");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.ContactName} - {item.CustomerID} - {item.OrderID} - {item.OrderDate}");
            }
        }
        public void Ejercicio8()
        {
            CustomerLogic logic = new CustomerLogic();
            var customers = logic.Listar();
            var query = customers.OrderByDescending(c => c.Region == "WA").Take(3).ToList();

            Console.WriteLine("Query para devolver los primeros 3 Customers de la  Región WA");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.ContactName} - {item.Region}");
            }
        }
        public void Ejercicio9()
        {
            ProductLogic logic = new ProductLogic();
            var products = logic.Listar();

            var query = from product in products
                        orderby product.ProductName
                        select product;

            Console.WriteLine("Query para devolver lista de productos ordenados por nombre");
       
            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductName}");
            }
        }
        public void Ejercicio10()
        {
            ProductLogic logic = new ProductLogic();
            var products = logic.Listar();

            var query = from product in products
                        orderby product.UnitsInStock descending
                        select product;

            Console.WriteLine("Query para devolver lista de productos ordenados por unit in stock de mayor a menor");

            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductName} - {item.UnitsInStock}");
            }
        }
        public void Ejercicio11()
        {
            ProductLogic p = new ProductLogic();
            CategoryLogic c = new CategoryLogic();
            var products = p.Listar();
            var categories = c.Listar();

            var query = from category in categories
                        join product in products
                        on category.CategoryID equals product.CategoryID
                        select new CategoriaProductos
                        {
                            CategoryID = category.CategoryID,
                            CategoryName = category.CategoryName,
                            ProductID = product.ProductID,
                            ProductName = product.ProductName
                        };

            Console.WriteLine("Query para devolver las distintas categorías asociadas a los productos");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CategoryName} - {item.CategoryID} - {item.ProductID} - {item.ProductName}");
            }
        }
        public void Ejercicio12()// error
        {
            ProductLogic logic = new ProductLogic();
            var products = logic.Listar();

            var query = products.ToList().FirstOrDefault();

            Console.WriteLine("Query para devolver el primer elemento de una lista de productos");
            Console.WriteLine($"{query}");

        }
        public void Ejercicio13()
        {
            CustomerLogic logic = new CustomerLogic();
            var customers = logic.Listar();
            OrderLogic orderLogic = new OrderLogic();
            var orders = orderLogic.Listar();

            var query = from customer in customers
                        join order in orders
                        on customer.CustomerID equals order.CustomerID
                        group customer by new
                        {
                            customer.CustomerID,
                            customer.ContactName,
                        } into custTable

                        select new CustomerOrder
                        {
                            CustomerID = custTable.Key.CustomerID,
                            ContactName = custTable.Key.ContactName,
                            CantOrdenes = custTable.Count()
                        };

            Console.WriteLine("Query para devolver los customer con la cantidad de ordenes asociadas");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.ContactName} - {item.CustomerID} - {item.CantOrdenes}");
            }
        }


    }
}


