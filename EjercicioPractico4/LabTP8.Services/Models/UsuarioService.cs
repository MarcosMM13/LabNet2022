using LabTP4.Entities.DTOs;
using LabTP4.Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP8.Services.Models
{
    public class UsuarioService
    {
        public async Task<List<Usuario>> ListUsuarios()
        {
            UsuarioLogic usuarioLogic = new UsuarioLogic(); 

            try
            {
                return await usuarioLogic.GetUsuarios();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
