using LabTP4.Logic.Logic;
using LabTP7.UI.Models;
using LabTP8.Services.Models;
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
        UsuarioService service = new UsuarioService();
        // GET: Usuario
        public async Task<ActionResult> Index()
        {
            var usuario = await service.ListUsuarios();
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