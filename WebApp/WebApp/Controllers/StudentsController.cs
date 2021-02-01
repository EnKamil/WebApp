using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/Students")]
    public class StudentsController : Controller
    {
        // GET
        public JsonResult Index()
        {
            return Json("Hey");
        }
    }
}