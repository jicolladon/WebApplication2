using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication1.Resources;

namespace WebApplication1.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Language), ErrorMessageResourceName = "RequiredName")]
        [Display(Name = "Name", ResourceType = typeof(Resources.Language))]
        public string Nombre { get; set; }

        [Display(Name= "Apellido", ResourceType=typeof(Resources.Language))]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Solo letras")]
        public string Apellido { get; set; }

        [Range (8,19)]
        public int Edad { get; set; }
        public bool Activo { get; set; }

        [EmailAddress]
        public string Email {get;set;}

        [DisplayFormat(DataFormatString ="{0:C}")]
        public double Sueldo { get; set; }
        public bool save()
        {
            
            return false;
        }
    }
}