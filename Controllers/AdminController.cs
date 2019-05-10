using System;
using Microsoft.AspNetCore.Mvc;

namespace web_mvc.Controllers
{
    [Route("painel/admin")]
    public class AdminController : Controller
    {
        [HttpGet("principal/{nome:string}")]
        public IActionResult Index(string nome) {
            return Content(nome + " é o cara");
        }

        [HttpGet("rotaTeste")]
        public IActionResult teste()
        {
            var nome = Request.Query["nome"];
            return Content("Esse é um teste de query com o " + nome);
        }
    }
}
