using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteMVC5.Models;

namespace TesteMVC5.Controllers
{
    public class AlunoController : Controller
    {
        [Route("novo-aluno")]
        public ActionResult Novo(Aluno aluno)
        {
            aluno = new Aluno
            {
                id = 1,
                nome = "Eduardo",
                cpf = "1234567895",
                dataMatricula = DateTime.Now,
                email = "teste@teste.com",
                ativo = true
            };

            return RedirectToAction("Index", aluno);
        }

        public ActionResult Index(Aluno aluno)
        {
            if (!ModelState.IsValid) return View(aluno);

            return View(aluno);
        }
    }
}