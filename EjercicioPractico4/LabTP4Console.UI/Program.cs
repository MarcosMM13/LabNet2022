using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabTP4.Entities;
using LabTP4.Logic;

namespace LabTP4Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

            Console.ReadKey();
        }

        #region Metodos
        #region Orders
        private static void GetOrdenes()
        {
            //Console.WriteLine("******Listado de Ordenes******");

            //ILogic<Orders> ol = new OrdersLogic();
            //var orders = ol.GetAll();

            //foreach (var item in orders)
            //{
            //    Console.WriteLine($"{item.OrderID} - {item.OrderDate} - {item.ShipName} - {item.ShipAddress}");
            //}
        }
        private static void AltaOrdenes()
        {

        }
        private static void BajaOrdenes()
        {

        }
        private static void ModificacionOrdenes()
        {

        }
        #endregion Orders
        #region Empleados
        private static void GetEmpleado()
        {
           
        }
        private static void AltaEmpleado()
        {

        }
        private static void BajaEmpleado()
        {

        }
        private static void ModificacionEmpleado()
        {

        }

        #endregion Empleados
        #region Region
        private static void GetRegion()
        {
            Console.WriteLine("Esto es Region");
            //RegionLogic rl = new RegionLogic();
            Region r = new Region();
            ILogic<Region> rl = new RegionLogic();

            foreach (var item in rl.GetAll())
            {
                Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
            }
        }
        private static void AltaRegion()
        {
            Region r = new Region();
            ILogic<Region> rl = new RegionLogic();

            foreach (var item in rl.GetAll())
            {
                Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
            }
            int? idRegion = r.RegionID;
            string descRegion = r.RegionDescription;

            try
            {
                Console.WriteLine("Ingrese el Id de la Region:");
                idRegion = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la descripcion:");
                descRegion = Console.ReadLine();

                rl.Add(new Region
                {
                    RegionID = (int)idRegion,
                    RegionDescription = descRegion
                });
                Console.WriteLine("Se guardo registro con exito!");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}");
            }
        }
        private static void BajaRegion()
        {
            Console.WriteLine("Aca se borra una Region");
            Region r = new Region();
            ILogic<Region> rl = new RegionLogic();
            int? idRegion = r.RegionID;
            string descRegion = r.RegionDescription;

            foreach (var item in rl.GetAll())
            {
                Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
            }
            try
            {
                foreach (var item in rl.GetAll())
                {
                    Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
                }

                Console.WriteLine("Ingrese el id de la region que quiere borrar");
                idRegion = int.Parse(Console.ReadLine());
                rl.Delete((int)idRegion);
                Console.WriteLine("se borro con exito");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}");
            }
        }
        private static void ModificacionRegion()
        {
            Console.WriteLine("Esto es actualizar la region");
            Region r = new Region();
            ILogic<Region> rl = new RegionLogic();
            int? idRegion = r.RegionID;
            string descRegion = r.RegionDescription;

            foreach (var item in rl.GetAll())
            {
                Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
            }

            try
            {
                foreach (var item in rl.GetAll())
                {
                    Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
                }

                Console.WriteLine("Modifique el Id de la Region:");
                idRegion = int.Parse(Console.ReadLine());
                Console.WriteLine("Modifique la descripcion:");
                descRegion = Console.ReadLine();

                if (idRegion != null)
                {
                    rl.Update(new Region
                    {
                        RegionDescription = descRegion,
                        RegionID = (int)idRegion
                    });
                }
                Console.WriteLine("Se actualizo con exito!");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}");
            }


            var region = rl.GetAll();
            foreach (var item in region)
            {
                Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
            }
            Console.WriteLine();

        }
        #endregion Region
        #region Territorios
        private static void GetTerritorios()
        {
            Console.WriteLine("******Listado de Territorio******");
            try
            {
                ILogic<Territory> tl = new TerritoriesLogic();
                var territorio = tl.GetAll();

                foreach (var item in territorio)
                {
                    Console.WriteLine($"{item.TerritoryID} - {item.RegionID} - {item.TerritoryDescription}");
                }
                Console.WriteLine("");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private static void ModificacionTerritorio()
        {
            Territory t = new Territory();
            ILogic<Territory> tl = new TerritoriesLogic();
            GetTerritorios();
            string idTerritorio = t.TerritoryID;
            string descTerritorio = t.TerritoryDescription;
            int? idRegion = t.RegionID;


            try
            {
                Console.WriteLine();
                Console.WriteLine("Modifique el Id de la Region:");
                idRegion = int.Parse(Console.ReadLine());
                Console.WriteLine("Modifique el Id del Territorio:");
                idTerritorio = Console.ReadLine();
                Console.WriteLine("Modifique la descripcion:");
                descTerritorio = Console.ReadLine();

                if (idTerritorio != null)
                {
                    tl.Update(new Territory
                    {
                        TerritoryID = idTerritorio,
                        TerritoryDescription = descTerritorio,
                        RegionID = (int)idRegion
                    });
                }
                Console.WriteLine("Se actualizo con exito!");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}");
            }


            GetTerritorios();
            Console.WriteLine();
        }

        private static void BajaTerritorio()
        {
            Territory t = new Territory();
            ILogic<Territory> tl = new TerritoriesLogic();
            GetTerritorios();
            string idTerritorio = t.TerritoryID;
            string descTerritorio = t.TerritoryDescription;
            int? idRegion = t.RegionID;

            try
            {
                GetTerritorios();

                Console.WriteLine("Ingrese el id de la region que quiere borrar");
                idRegion = int.Parse(Console.ReadLine());
                //tl.Delete(idTerritorio);
                Console.WriteLine("se borro con exito");
                Console.WriteLine("");

                GetTerritorios();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}");
            }
        }

        private static void AltaTerritorios()
        {
            Territory t = new Territory();
            ILogic<Territory> tl = new TerritoriesLogic();
            GetTerritorios();
            string idTerritorio = t.TerritoryID;
            string descTerritorio = t.TerritoryDescription;
            int? idRegion = t.RegionID;

            try
            {
                Console.WriteLine("Ingrese el Id de la Region:");
                idRegion = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Id del Territorio:");
                idTerritorio = Console.ReadLine();
                Console.WriteLine("Ingrese la descripcion:");
                descTerritorio = Console.ReadLine();

                tl.Add(new Territory
                {
                    TerritoryID = idTerritorio,
                    TerritoryDescription = descTerritorio,
                    RegionID = (int)idRegion

                });
                Console.WriteLine("Se guardo registro con exito!");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}");
            }
        }
        #endregion Territorios
        #region Menus
        private static void Menu()
        {
            string option = "";

            do
            {
                Console.Clear();
                Console.WriteLine("*******NORTHWIND*******");
                ShowMenuGeneral();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        MenuEmpleados();
                        break;
                    case "2":
                        MenuRegion();
                        break;
                    case "3":
                        MenuTerritorio();
                        break;
                    case "4":
                        break;
                    case "5":
                        About();
                        break;
                    case "6":
                        break;

                    default:
                        Console.WriteLine("Opcion No Valida");
                        break;
                }
            } while (option != "6");

            Console.ReadKey();
        }




        private static void MenuEmpleados()
        {
            string option = "";
            EmployeeUI employeeUI = new EmployeeUI();

            do
            {
                Console.Clear();
                Console.WriteLine("*******Menu de Empleados*******");
                ShowMenuEmpleados();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AltaEmpleado();
                        Console.ReadKey();
                        break;
                    case "2":
                        BajaEmpleado();
                        Console.ReadKey();
                        break;
                    case "3":
                        ModificacionEmpleado();
                        Console.ReadKey();
                        break;
                    case "4":
                        employeeUI.Listar();
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
        private static void MenuRegion()
        {
            string option = "";

            do
            {
                Console.Clear();
                Console.WriteLine("*******Regiones*******");
                ShowMenuRegion();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AltaRegion();
                        break;
                    case "2":
                        BajaRegion();
                        break;
                    case "3":
                        ModificacionRegion();
                        break;
                    case "4":
                        GetRegion();
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
        private static void MenuTerritorio()
        {
            string option = "";
            TerritoriesUI territoriesUI = new TerritoriesUI();
            do
            {
                Console.Clear();
                Console.WriteLine("*******Territorios*******");
                ShowMenuTerritorio();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        territoriesUI.Alta();
                        Console.ReadKey();
                        break;
                    case "2":
                        territoriesUI.Baja();
                        Console.ReadKey();
                        break;
                    case "3":
                        territoriesUI.Modificacion();
                        Console.ReadKey();
                        break;
                    case "4":
                        territoriesUI.Listar();
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



        private static void ShowMenuGeneral()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Empleados");
            sb.AppendLine("2. Region");
            sb.AppendLine("3. Territorios");
            sb.AppendLine("4. Ordenes");
            sb.AppendLine("5. Acerca De");
            sb.AppendLine("6. Salir");
            sb.Append("Seleccione una Opcion");

            Console.WriteLine(sb.ToString());
        }

        private static void ShowMenuEmpleados()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Alta de Empleados");
            sb.AppendLine("2. Baja de Empleados");
            sb.AppendLine("3. Modificacion de Empleados");
            sb.AppendLine("4. Ver Listado de Empleados");
            sb.AppendLine("5. Salir");
            sb.Append("Seleccione una Opcion");

            Console.WriteLine(sb.ToString());
        }
        private static void ShowMenuRegion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Alta de Region");
            sb.AppendLine("2. Baja de Region");
            sb.AppendLine("3. Modificacion de Region");
            sb.AppendLine("4. Ver Listado de Regiones");
            sb.AppendLine("5. Salir");
            sb.Append("Seleccione una Opcion");

            Console.WriteLine(sb.ToString());
        }
        private static void ShowMenuTerritorio()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Alta de Territorio");
            sb.AppendLine("2. Baja de Territorio");
            sb.AppendLine("3. Modificacion de Territorios");
            sb.AppendLine("4. Ver Listado de Territorios");
            sb.AppendLine("5. Salir");
            sb.Append("Seleccione una Opcion");

            Console.WriteLine(sb.ToString());
        }


        private static void About()
        {
            Console.WriteLine("Nombre: Marcos Mateos");
            Console.WriteLine("Presiona para continuar.");
            Console.ReadKey();
        }
        #endregion Menus
        #endregion Metodos
    }
}
