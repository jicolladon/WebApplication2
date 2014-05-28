using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class MedicosController : ApiController
    {
        private CitasContext _context;
        public MedicosController()
        {
            _context = new CitasContext();
        }
        // GET api/medicos
        public IEnumerable<Medico> Get()
        {
            _context.Medicos.Add(new Medico(){Id=1, Nombre="Pepe"});
            var medicos = _context.Medicos.OrderBy(d => d.Nombre);
            return medicos;
        }

        // GET api/medicos/5
        public Medico Get(int id)
        {
            var medico = _context.Medicos.FirstOrDefault(d => d.Id == id);
            return medico;
        }

        public HttpResponseMessage Post(Medico med)
        {
            try
            {
                _context.Medicos.Add(med);
                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
           
        }
        // POST api/medicos
      
    }
}
