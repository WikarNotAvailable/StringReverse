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

        public ActionResult ShowInputPanel()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Reverse()
        {
            var stringToReverse = Request.Form["stringToReverse"];
            var reversedString = _reversionModel.ReverseString(stringToReverse);

            ViewBag.ReversedString = reversedString;
            ViewBag.OldString = stringToReverse;
            return View();
        }
    }
}
