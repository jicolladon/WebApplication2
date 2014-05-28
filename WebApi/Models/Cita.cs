using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Cita
    {
        public int Id { get; set; }
        [Required]
        public int IdMedico { get; set; }
        [Required]
        public String NombrePaciente { get; set; }
        [Required]
        public DateTime FechaCita { get; set; }
        public String Razon { get; set; }
    }
}