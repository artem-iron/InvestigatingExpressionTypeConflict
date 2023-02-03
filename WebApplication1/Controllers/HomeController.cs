using System.Linq;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IronXL.WorkSheet ws = new IronXL.WorkBook().DefaultWorkSheet;

            ws["A2"].StringValue = "ass";

            System.Func<IronXL.Cell, bool> ass = (cell) =>
            {
                if (cell.StringValue == "ass")
                {
                    return true;
                }
                else
                    return false;
            };

            IronXL.Cell asss = ws["A1:A2"].FirstOrDefault(ass);

            System.Linq.Expressions.ExpressionType expressionType = System.Linq.Expressions.ExpressionType.Add;

            ViewBag.Title = expressionType.ToString() + asss.StringValue + ass.ToString();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}