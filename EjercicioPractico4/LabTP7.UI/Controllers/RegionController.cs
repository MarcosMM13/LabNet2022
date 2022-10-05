using LabTP4.Entities;
using LabTP4.Logic;
using LabTP7.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTP7.UI.Controllers
{
    public class RegionController : Controller
    {
         RegionLogic logic = new RegionLogic();
        // GET: Region
        public ActionResult Index()
        {
            List<Region> regiones = logic.GetAll();

            List<RegionView> regionViews = regiones.Select(s => new RegionView
            {
                Id = s.RegionID,
                Description = s.RegionDescription
            }).ToList();

            return View(regionViews);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(RegionView regionView)
        {
            try
            {
                var regionEntity = new Region { RegionDescription = regionView.Description};
                logic.Add(regionEntity);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}