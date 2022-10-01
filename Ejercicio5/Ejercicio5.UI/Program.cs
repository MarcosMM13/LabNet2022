using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio5.Logic;
using Ejercicio5.Entities;

namespace Ejercicio5.UI
{
    class Program
    {
        static void Main(string[] args)
        {            
            CustomerUI customerUI = new CustomerUI();
            ProductUI productUI = new ProductUI();

            Console.WriteLine("**************EJERCICIO 1**************");
            Console.WriteLine();            

            //customerUI.Ejercicio1();

            Console.WriteLine("**************EJERCICIO 2**************");

            productUI.Ejercicio2();


            Console.ReadKey();
        }
    }
}
