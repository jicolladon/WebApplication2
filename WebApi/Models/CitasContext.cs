using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class CitasContext :DbContext
    {
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
    }
}