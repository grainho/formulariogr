using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace form.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.resposta = "";
            return View();
        }



        [HttpPost]
        public ActionResult Index(string nome, int? idade)
        {


            String msg = "";
            /// precisamos de validar os dados introduzidos
            /// 1ª questão: o 'nome' é um nome?
            /// 2ª questão: a idade está dentro dos parametros pretendidos[0; 120]?


            //validar a idade

            if (idade >= 0 && idade <= 120)
            {
                //criar a mensagem de resposta
                msg = "Voce chama-se " + nome + " e tem " + idade + " anos.";
            }
            else
            {
                //mensagem alternativa
                msg = "Deve especificar uma idade válida!\nA idade deve ser maior que 0 e menor que 120 anos.";
            }
            //criar o 'contentor' que levará a mensagem para a view
            ViewBag.resposta = msg;

            //invoca a view
            return View();
        }
    }
}