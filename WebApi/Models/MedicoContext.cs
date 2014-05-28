using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class MedicoContext : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }
    }
}