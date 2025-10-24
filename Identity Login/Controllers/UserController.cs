using Identity_Login.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Identity_Login.Controllers
{
    [Authorize(Roles = RolesSD.USER)]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
