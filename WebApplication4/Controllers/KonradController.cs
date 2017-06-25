using System.Web;
using System.Web.Mvc;
using ModelBindingContext = System.Web.Mvc.ModelBindingContext;

namespace WebApplication4.Controllers
{
    public class KonradController : Controller
    {
        // GET: Konrad
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload()
        {
            var file = Request.Files["file"];
            using (var stream = file.InputStream)
            {
                //Zrób coś fajnego;
            }
            return Json(new {});
        }


        public ActionResult UploadPro(Model model)
        {

            return Json(new {});
        }
    }

    public class CustomModelBinder : System.Web.Mvc.IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var file = controllerContext.HttpContext.Request.Files["file"];
            var firstName = controllerContext.HttpContext.Request["firstName"];
            return new Model
            {
                File = file,
                FirstName = firstName
            };
        }
    }

    [ModelBinder(typeof(CustomModelBinder))]
    public class Model
    {
        public string FirstName { get; set; }
        public HttpPostedFileBase File { get; set; }
    }
}