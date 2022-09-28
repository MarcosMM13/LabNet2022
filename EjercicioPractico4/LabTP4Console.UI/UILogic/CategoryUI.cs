using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabTP4.Entities;
using LabTP4.Logic;

namespace LabTP4Console.UI
{
    class CategoryUI : BaseUI<Category>
    {
        public override void Alta()
        {
            Category logic = new Category();
            ILogic<Category> iLogic = new CategoryLogic();
            int? idCategoria = logic.CategoryID;
            string catNombre = logic.CategoryName;
            string catDescripcion = logic.Description;

            try
            {
                Console.WriteLine("Ingrese el Id de la nueva categoria:");
                idCategoria = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre de la categoria:");
                catNombre = Console.ReadLine();
                Console.WriteLine("Ingrese la descripcion de la categoria:");
                catDescripcion = Console.ReadLine();

                iLogic.Add(new Category
                {
                    CategoryID = (int)idCategoria,
                    CategoryName = catNombre,
                    Description = catDescripcion
                });
                Console.WriteLine("Se guardo registro con exito!");
                Console.WriteLine("Asi queda actualizada el listado de Categorias:");
                Listar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
        public override void Baja()
        {
            Console.WriteLine("Listado de Registros Actualizado");
            Category logic = new Category();
            ILogic<Category> iLogic = new CategoryLogic();
            int? idCategoria = logic.CategoryID;
            string catNombre = logic.CategoryName;
            string catDescripcion = logic.Description;
     

            try
            {
                Console.WriteLine("Ingrese el id de la orden que desea borrar");
                idCategoria = int.Parse(Console.ReadLine());
                iLogic.Delete((int)idCategoria);
                Console.WriteLine("Se borro el registro con exito");
                Console.WriteLine("Asi queda actualizada la listado de categorias:");
                Listar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se puede eliminar el registro seleccionado por" +
                    $"contener relacion con los Productos cargados.");
                Console.WriteLine("Ver listados de registros y seleccione otra Id para eliminar.");
                Console.WriteLine($"Descripcion del error: {ex.Message}");
            }
        }

        public override void Listar()
        {
            Console.WriteLine("******Listado de Categorias de Producto******");
            try
            {
                ILogic<Category> cl = new CategoryLogic();
                var territorio = cl.GetAll();

                foreach (var item in territorio)
                {
                    Console.WriteLine($"{item.CategoryID} - {item.CategoryName} - {item.Description}");
                }
                Console.WriteLine("");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override void Modificacion()
        {
            Console.WriteLine("Listado de Registros Actualizado");
            Category logic = new Category();
            ILogic<Category> iLogic = new CategoryLogic();
            int? idCategoria = logic.CategoryID;
            string catNombre = logic.CategoryName;
            string catDescripcion = logic.Description;
           

            try
            {
                Console.WriteLine("Modifique el Id de la nueva categoria:");
                idCategoria = int.Parse(Console.ReadLine());
                Console.WriteLine("Modifique el nombre de la categoria:");
                catNombre = Console.ReadLine();
                Console.WriteLine("Modifique la descripcion de la categoria:");
                catDescripcion = Console.ReadLine();

                iLogic.Update(new Category
                {
                    CategoryID = (int)idCategoria,
                    CategoryName = catNombre,
                    Description = catDescripcion
                });
                Console.WriteLine("Se guardo registro con exito!");
                Console.WriteLine("Asi queda actualizada la listado de categorias:");
                Listar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
        public override void Menu()
        {
            string option = "";

            do
            {
                Console.Clear();
                Console.WriteLine("*******Menu de Categorias*******");
                ShowMenu();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Alta();
                        Console.ReadKey();
                        break;
                    case "2":
                        Baja();
                        Console.ReadKey();
                        break;
                    case "3":
                        Modificacion();
                        Console.ReadKey();
                        break;
                    case "4":
                        Listar();
                        Console.ReadKey();
                        break;
                    case "5":
                        break;

                    default:
                        Console.WriteLine("Opcion No Valida");
                        break;
                }
            } while (option != "5");

            Console.ReadKey();
        }
        public override void ShowMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Alta de Categorias");
            sb.AppendLine("2. Baja de Categorias");
            sb.AppendLine("3. Modificacion de Categorias");
            sb.AppendLine("4. Ver Listado de Categorias");
            sb.AppendLine("5. Salir");
            sb.Append("Seleccione una Opcion");

            Console.WriteLine(sb.ToString());
        }
    }

}

