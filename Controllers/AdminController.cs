using System;
using Microsoft.AspNetCore.Mvc;

namespace web_mvc.Controllers
{
    [Route("painel/admin")]
    public class AdminController : Controller
    {
        [HttpGet("principal/{nome}")]
        public IActionResult Index(string nome) {
            return Content(nome + " é o cara");
        }

        [HttpGet("rotaTeste")]
        public IActionResult teste()
        {
            var nome = Request.Query["nome"];
            return Content("Esse é um teste de query com o " + nome);
        }

        [HttpGet("view")]
        public IActionResult visualizar()
        {
            ViewData["helloWorld"] = true;
            ViewData["nome"] = "pedro";
            return View("nada");
        }
    }
}
