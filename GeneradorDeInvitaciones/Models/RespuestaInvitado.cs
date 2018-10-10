using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneradorDeInvitaciones.Models
{
    public class RespuestaInvitado
    {
        [Required(ErrorMessage = "Por favor ingrese un nombre")]
        public String nombre { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un correo electrónico")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Por favor ingrese correo válido")]
        public String correo { get; set; }
        [Required(ErrorMessage = "Por favor ingrese teléfono")]
        public String telefono { get; set; } 
        [Required(ErrorMessage = "Por favor confirme asistencia")]
        public bool? asistira { get; set; }
    }
}