using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP4.Commons
{
    public static class Validaciones
    {
        public static void AddCategoriaVal(ref int? idCategoria, ref string catNombre, ref string catDescripcion)
        {
            while (idCategoria < 0 || idCategoria == null)
            {
                Console.WriteLine("Ha ingresado un registro invalido por favor revise los datos ingresados");
                Console.WriteLine("Ingrese el Id de la nueva categoria:");
                idCategoria = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre de la categoria:");
                catNombre = Console.ReadLine();
                Console.WriteLine("Ingrese la descripcion de la categoria:");
                catDescripcion = Console.ReadLine();
            }
        }

        public static void DeleteCategoriaVal(ref int? idCategoria)
        {
            while (idCategoria < 0 || idCategoria == null)
            {
                Console.WriteLine("Ha ingresado un registro invalido por favor revise los datos ingresados");
                Console.WriteLine("Ingrese el Id de la categoria que desea borrar:");
                idCategoria = int.Parse(Console.ReadLine());
            }
        }
        public static void UpdateCategoriaVal(ref int? idCategoria, ref string catNombre, ref string catDescripcion)
        {
            while (idCategoria < 0 || idCategoria == null)
            {
                Console.WriteLine("Ha ingresado un Id invalido por favor revise los datos ingresados");
                Console.WriteLine("Modifique el Id de la nueva categoria:");
                idCategoria = int.Parse(Console.ReadLine());
                Console.WriteLine("Modifique el nombre de la categoria:");
                catNombre = Console.ReadLine();
                Console.WriteLine("Modifique la descripcion de la categoria:");
                catDescripcion = Console.ReadLine();
            }
        }
    }
}
