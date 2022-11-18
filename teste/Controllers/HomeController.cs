using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using teste.Models;

namespace teste.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Entrar(LoginModelcs loginModelcs)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (loginModelcs.Login == "adm" && loginModelcs.Senha == "123")
                    {
                        return RedirectToAction("index", "Home");
                    }
                    TempData["MensagemError"] = $"tente Novamente";
                };
                return View("index");
            }
            catch (Exception)
            {
                TempData["MensagemErro"] = $"erro";
            }
        }
    }
}