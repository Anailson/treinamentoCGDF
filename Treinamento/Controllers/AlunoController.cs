using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Treinamento.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {

            /*CRIANDO ARRAY*/
            string[] alunos =
            {
                "José",
                "João",
                "maria"

            };
            return View(alunos);
        }
    }
}
