using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public partial class Usuarios
    {
        public int Id { get; set; }

        [Required]        
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

     
        public string Estado { get; set; }

        [Required]
        public string Cedula { get; set; }

      
        public string Cola { get; set; }

       
    }
}
