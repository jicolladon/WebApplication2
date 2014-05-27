using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Alert
    {

        public String CssClass { get; set; }
        public string id { get; set; }
        public string Title { get; set; }
        public string Error { get; set; }
        public List<string> Errors { get; set; }
        public Alert()
        {
            CssClass = "alertDanger";
        }
    }
}