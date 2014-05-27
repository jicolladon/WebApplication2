using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Base/

        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            String culture = "es";
            culture = (Request.RawUrl.Length > 1) ? Request.RawUrl.Substring(1,2) : "es-Es";
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            return base.BeginExecuteCore(callback, state);
        }
    }
}
