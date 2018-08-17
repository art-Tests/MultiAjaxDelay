using System.Web.Mvc;
using System.Web.SessionState;
using MultiAjaxDelay.Models;

namespace MultiAjaxDelay.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    public class TestController : Controller
    {
        public ActionResult DelayNum(int delaySec, string begin) => Content(AjaxTest.DelayByNum(delaySec, begin));

        public ActionResult Delay5(string begin) => Content(AjaxTest.Delay5(begin));

        public ActionResult Delay0(string begin) => Content(AjaxTest.Delay0(begin));
    }
}