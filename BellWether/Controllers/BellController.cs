using System.Web.Mvc;
using BellWether.Models;

namespace BellWether.Controllers
{
    public class BellController : Controller
    {

        //
        // GET: /Admin/BellAdmin/Create

        public ActionResult Create()
        {
            var bell = new Bell();
            return View(bell);
        } 

        //
        // POST: /Admin/BellAdmin/Create

        [HttpPost]
        public ActionResult Create(Bell model)
        {
            try
            {
                BellwetherContext ctx = new BellwetherContext();
                model.User = new User() {UserName = User.Identity.Name};
                ctx.Bells.Add(model);
                ctx.SaveChanges();
               

                return RedirectToAction("Index", new { controller = "Home"} );
            }
            catch
            {
                return View();
            }
        }
        






    }
}
