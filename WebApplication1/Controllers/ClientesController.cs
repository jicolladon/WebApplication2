using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    enum OrderType
    {
        Asc,Desc
    }
    public class ClientesController : BaseController
    {
        //
        // GET: /Clientes/
        private ClientContext _context;

        public ClientesController()
        {
            _context = new ClientContext();
        }
        private int page;
        public ActionResult Index()
        {
            page = 0;
            //var clientes = Clientes.Instance.ClientList;
            var clientes = _context.Clientes.OrderBy(x => x.Nombre).OrderBy(d => d.Nombre).Skip(page * 10).Take(10);
            return View(clientes);
        }
        public ActionResult EditarClientes()
        {
            page = 0;
            var clientes = _context.Clientes.OrderBy(d => d.Nombre).Skip(page * 10).Take(10);
            return View(clientes);
        }
        public ActionResult Razor()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            //var clientes = Clientes.Instance.ClientList;
            //var cliente = clientes.FirstOrDefault(x => x.Id == id);
            var cliente = _context.Clientes.FirstOrDefault(x => x.Id == id);
            return View("Details",cliente);
        }
        public ActionResult ContactEdition(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(x => x.Id == id);
            return View("ContactEdition", cliente);
        }
        [HttpPost]
        public ActionResult ContactEdition(int id,Cliente c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var cliente = _context.Clientes.FirstOrDefault(x => x.Id == id);
                    if (cliente != null)
                    {
                        cliente.Nombre = c.Nombre;
                        cliente.Apellido = c.Apellido;
                        cliente.Edad = c.Edad;
                        _context.SaveChanges();
                    }
                    c.Id = id;
                    //var clientes = Clientes.Instance;
                    //clientes.Replace(id, c);
                    return View("Details", c);
                }
                else
                {
                    return View("ContactEdition", c);
                }
            }
            catch
            {
                return View("ContactEdition", c); 
            }
            
         
        }
        public ActionResult Create()
        {
            return View("Create");
        }
        
        [HttpPost]
        public ActionResult Create(Cliente c)
        {
            if (ModelState.IsValid)
            {
                _context.Clientes.Add(c);
                _context.SaveChanges();
                //c.Id = Clientes.Instance.ClientList.Count;
                //Clientes.Instance.añadirCliente(c);
                return View("Details", c);
            }
            else
                return View("Create", c);
        }
        public ActionResult Delete(int id)
        {
            var clientes = _context.Clientes;
            var cliente = clientes.FirstOrDefault(x => x.Id == id);
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Delete(int id, Cliente cliente)
        {
            //var clientes = Clientes.Instance;
            //bool result = clientes.Delete(id);
            var cli = _context.Clientes.FirstOrDefault(x => x.Id == id);

            if (cli != null)
            {
                _context.Clientes.Remove(cli);
                _context.SaveChanges();
                return View("EditarClientes", _context.Clientes.OrderBy(d => d.Nombre).Skip(page * 10).Take(10));
            }
            return View("Delete", cliente);
        }

        public ActionResult OrderByName(String order)
        {
            page = 0;
            var clientes = _context.Clientes;
            if (order == "Asc")
            {
                var listaOrdenada = clientes.OrderBy(d => d.Nombre);
                return View("EditarClientes", listaOrdenada.OrderBy(d => d.Nombre).Skip(page * 10).Take(10));
            }
            else
            {
                var listaOrdenada = clientes.OrderByDescending(d => d.Nombre);
                return View("EditarClientes", listaOrdenada.OrderBy(d => d.Nombre).Skip(page * 10).Take(10));
            }
        }
        public ActionResult Search(String SearchString)
        {
            var clientes = _context.Clientes.Where(d => d.Nombre.Contains(SearchString)
                || d.Apellido.Contains(SearchString) || d.Email.Contains(SearchString)).OrderBy(x=>x.Nombre);
            return View("EditarClientes", clientes.OrderBy(d => d.Nombre).Skip(page * 10).Take(10));
        }
        public ActionResult giveMeNext()
        {
            var maxpag = _context.Clientes.Count()/10;
            if(page < maxpag)
            {
                page = page +1;
                var cli = _context.Clientes.OrderBy(d => d.Nombre).Skip(page * 10).Take(10);
                return View("EditarClientes", cli);
            }
            else
            {
                page++;
                var cli = _context.Clientes.OrderBy(d => d.Nombre).Skip(page * 10);
                return View("EditarClientes", cli);
            }
           
        }
        public ActionResult giveMeBefore()
        {
            var maxpag = _context.Clientes.Count() / 10;
            if (page - 1 > 0)
            {
                page--;
            }
            var cli = _context.Clientes.OrderBy(d => d.Nombre).Skip(page * 10).Take(10);
            return View("EditarClientes", cli);
        }
    }
}
