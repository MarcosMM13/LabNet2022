using LabTP4.Logic.Logic;
using LabTP7.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LabTP7.UI.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioLogic logic = new UsuarioLogic();
        // GET: Usuario
        public async Task<ActionResult> Index()
        {
            var usuario = await logic.GetUsuarios();
            var lista = usuario.Select(u => new UsuarioView
            {
                Id = u.Id,
                UserId = u.UserId,
                Body = u.Body,
                Title = u.Title
            }).ToList();

            return View(lista);
        }
    }
}