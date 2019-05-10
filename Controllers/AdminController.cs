using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

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

        [HttpGet("form")]
        public IActionResult form()
        {
            return View();;
        }

        [HttpPost("dados")]
        public IActionResult dados()
        {
            StringValues nome;
            StringValues email;
            Request.Form.TryGetValue("nome", out nome);
            Request.Form.TryGetValue("email", out email);
            return Content("Form Enviado!" + nome + email);
        }
    }
}
