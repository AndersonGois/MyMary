using System.Linq;
using System.Web.Mvc;
using Facade;


namespace Mvc.Mary.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteFacade _clienteFacade = new ClienteFacade();

        public ActionResult Index()
        {
            var clientes = _clienteFacade.GetTodosClientes();
            ViewBag.Clientes = clientes;
            var item = clientes.Select(x => new SelectListItem {Text = x.Nome, Value = x.Id.ToString()});

            ViewBag.Teste = item;

            return View();
        }

    }
}
