using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StringReverse.Models;

namespace StringReverse.Controllers
{
    public class StringReversionController : Controller
    {
        private readonly StringReversionModel _reversionModel = new StringReversionModel();
        // GET: StringReversionController
        public ActionResult Index()
        {
            return View();
        }

       
    }
}
