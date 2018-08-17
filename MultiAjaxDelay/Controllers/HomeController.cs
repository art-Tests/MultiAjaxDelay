using System.Web.Mvc;
using MultiAjaxDelay.Models;

namespace MultiAjaxDelay.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => View();

        public ActionResult SimuAjaxCall(int seqNo, int delay) => Content(AjaxTest.DelayByNum(delay, "", seqNo));

        public ActionResult Snail()
        {
            Session["A"] = 123;
            return Content("Server端使用Session");
        }

        public ActionResult Delay5(string begin) => Content(AjaxTest.Delay5(begin));

        public ActionResult Delay0(string begin) => Content(AjaxTest.Delay0(begin));
    }
}