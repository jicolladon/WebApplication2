using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Clientes
    {
        public List<Cliente> ClientList { get; set; }

        private static Clientes _clientes;
        public void añadirCliente(Cliente c)
        {
            ClientList.Add(c);
        }
        public static Clientes Instance
        {
            get
            {
                if (_clientes == null)
                {
                    _clientes = new Clientes();
                }
                return _clientes;
            }
        }

        private Clientes()
        {
            ClientList = new List<Cliente>();
            ClientList.Add(new Cliente { Id = 1, Nombre = "marc", Apellido = "Marc", Edad = 18, Activo = true, Email = "ejemplo@ejemplo.es", Sueldo = 50.0 });
            ClientList.Add(new Cliente { Nombre = "marc1", Apellido = "Marc1", Edad = 181, Activo = false, Email = "ejemplo@ejemplo.es", Sueldo = 50.0 });
            ClientList.Add(new Cliente { Nombre = "marc2", Apellido = "Marc2", Edad = 182, Activo = false, Email = "ejemplo@ejemplo.es", Sueldo = 50.0 });
            ClientList.Add(new Cliente { Nombre = "marc3", Apellido = "Marc3", Edad = 183, Activo = true, Email = "ejemplo@ejemplo.es", Sueldo = 50.0 });
        }

        public bool Delete(int id)
        {
            return ClientList.Remove(ClientList.FirstOrDefault(x => x.Id == id));
        }

        public bool Replace(int id, Cliente c)
        {
            if (ClientList.Remove(ClientList.FirstOrDefault(x => x.Id == id)))
            {
                ClientList.Add(c);
                return true;
            }
            return false;
        }
    }
}