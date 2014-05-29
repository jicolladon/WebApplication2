using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApi.Models;
namespace WebApi.Controllers
{
    public class CitaController : Controller
    {
        //
        // GET: /Cita/
        public ActionResult Index()
        {

            return View();
        }

        //
        // GET: /Cita/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Cita/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cita/Create
        [HttpPost]
        public ActionResult Create(Cita cita)
        {
            try
            {
                if (ModelState.IsValid)
                {
                     //http://msdn.microsoft.com/en-us/library/jj819168.aspx
                    var uri = new Uri("http://localhost/Api/Citas");
                    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
                    request.Method = "POST";
                    request.ContentType = "text/plain;charset=utf-8";
                    System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();

                    //HttpWebRequest wc =WebRequest.Create("") as HttpWebRequest;

                    //wc.Method = "POST";
                    //wc.Headers.Add("Content-Type")
                    //wc.GetRequestStream
                    //wc.DownloadData("");
                    //wc.GetResponse().GetResponseStream
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Create", cita);
                }
                // TODO: Add insert logic here

            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cita/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Cita/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cita/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Cita/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
