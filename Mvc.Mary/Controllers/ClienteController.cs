using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facade;

namespace Mvc.Mary.Controllers
{
    public class ClienteController : Controller
    {
        // GET: /Cliente/
        private  ClienteFacade clienteFacade = new ClienteFacade();

        public ActionResult Index()
        {
            ViewBag.Teste = clienteFacade.GetTodosClientes().FirstOrDefault().Descricao;
            
            return View();
        }

    }
}
