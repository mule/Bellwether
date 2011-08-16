using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BellWether.Areas.Admin.Controllers
{
    public class BellAdminController : Controller
    {




        //
        // GET: /Admin/BellAdmin/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Admin/BellAdmin/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index", new { area = "Admin", controller = "Home"} );
            }
            catch
            {
                return View();
            }
        }
        






    }
}
