using LabTP4.Data;
using LabTP4.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LabTP4.Logic.Logic
{
    public class UsuarioLogic
    {
        UsuarioApiContext context = new UsuarioApiContext();

        public async Task<List<Usuario>> GetUsuarios()
        {
            try
            {
            var usuario = await context.GetUsuariosAsync();

            var respuesta = usuario.Select(u => new Usuario
            {
                Id = u.Id,
                UserId = u.UserId,
                Body = u.Body,
                Title = u.Title
            }).ToList();

            return respuesta;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
