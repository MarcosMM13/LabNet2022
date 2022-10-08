using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LabTP7.UI.Models
{
    public class CategoryView
    {
        public int CategoryID { get; set; }

        [Required]
        [StringLength(15,ErrorMessage ="El Nombre debe tener menos de 15 caracteres" )]
        public string Nombre { get; set; }
        [Column(TypeName = "ntext")]
        public string Descripcion { get; set; }
    }
}