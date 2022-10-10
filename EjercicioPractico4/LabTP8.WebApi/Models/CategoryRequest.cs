using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabTP8.WebApi.Models
{
    public class CategoryRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

    }
}