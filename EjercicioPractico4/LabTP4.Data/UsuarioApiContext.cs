using LabTP4.Entities.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace LabTP4.Data
{
    public class UsuarioApiContext
    {
        public async Task<List<Usuario>> GetUsuariosAsync()
        {         
            var httpClient = new HttpClient();
            var respuesta = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");
            var respuestaString = await respuesta.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<Usuario>>(respuestaString);
               
          

            return list;
        }
    }
}
