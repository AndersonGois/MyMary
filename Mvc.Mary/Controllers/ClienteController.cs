using System.Collections.Generic;
using System.Globalization;
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

            ViewBag.Pais = Paises();
            ViewBag.Estado = Estados(1);
            ViewBag.Cidade = Cidades(1);

            return View();
        }
        private static IEnumerable<SelectListItem> Vazio()
        {
            var item = new SelectListItem { Text = "", Value = "0", Selected = true };
            var vazio = new SelectListItem[1];
            vazio.SetValue(item, 0);
            return vazio;
        }
        private IEnumerable<SelectListItem> Paises()
        {
            return _clienteFacade.GetPais().Select(x => new SelectListItem { Text = x.Descricao, Value = x.Id.ToString(CultureInfo.InvariantCulture) }).Union(Vazio());
        }

        private IEnumerable<SelectListItem> Estados(int id)
        {
            return _clienteFacade.GetEstadosPorPais(id).Select(x => new SelectListItem { Text = x.Descricao, Value = x.Id.ToString(CultureInfo.InvariantCulture) }).Union(Vazio());
        }

        private IEnumerable<SelectListItem> Cidades(int id)
        {
            return _clienteFacade.GetCidadesPorEstado(id).Select(x => new SelectListItem { Text = x.Descricao, Value = x.Id.ToString(CultureInfo.InvariantCulture) }).Union(Vazio());
        }


    }
}
