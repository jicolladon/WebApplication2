using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Beer> Get()
        {
            var lista = new List<Beer>();
            lista.Add(new Beer() { Id = 1, Name = "Hola" });
            lista.Add(new Beer() { Id = 2, Name = "cerveza2" });
            lista.Add(new Beer() { Id = 3, Name = "cerveza3" });
            return lista;
        }

        public Beer Get(int id)
        {
            var lista = new List<Beer>();
            lista.Add(new Beer() { Id = 1, Name = "Hola" });
            lista.Add(new Beer() { Id = 2, Name = "cerveza2" });
            lista.Add(new Beer() { Id = 3, Name = "cerveza3" });
            return lista[0];
        }

        public bool Post(Beer beer)
        {

            return true;
        }
    }
}
