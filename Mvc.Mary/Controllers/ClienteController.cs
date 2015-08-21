using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using Domain.Entities;
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


        public ActionResult Teste(int id)
        {
         
            return Json(Paises(), JsonRequestBehavior.AllowGet);
            
        }


        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            ViewBag.Pais = Paises();
            ViewBag.Estado = Estados(1,cliente.Endereco.Estado.Id);
            ViewBag.Cidade = Cidades(cliente.Endereco.Estado.Id, cliente.Endereco.Cidade.Id);

            return View();
        }

        private static IEnumerable<SelectListItem> Vazio()
        {
            var item = new SelectListItem { Text = "", Value = "0", Selected = true };
            var vazio = new SelectListItem[1];
            vazio.SetValue(item, 0);
            return vazio;
        }

        private IEnumerable Paises()
        {
            var pais = (from b in _clienteFacade.GetPais()
                     select new {id = b.Id, name=b.Descricao });
            return pais;
        }

        private IEnumerable<SelectListItem> Estados(int id)
        {
            return _clienteFacade.GetEstadosPorPais(id).Select(x => new SelectListItem { Text = x.Descricao, Value = x.Id.ToString(CultureInfo.InvariantCulture) }).Union(Vazio());
        }

        private IEnumerable<SelectListItem> Cidades(int id)
        {
            return _clienteFacade.GetCidadesPorEstado(id).Select(x => new SelectListItem { Text = x.Descricao, Value = x.Id.ToString(CultureInfo.InvariantCulture) }).Union(Vazio());
        }

        private IEnumerable<SelectListItem> Paises(int id)
        {
            return _clienteFacade.GetPais().Select(x => new SelectListItem { Text = x.Descricao, Value = x.Id.ToString(CultureInfo.InvariantCulture), Selected = true }).Union(Vazio());
        }

        private IEnumerable<SelectListItem> Estados(int id, int estadoId)
        {
            return _clienteFacade.GetEstadosPorPais(id).Where(x => x.Id == estadoId).Select(x => new SelectListItem { Text = x.Descricao, Value = x.Id.ToString(CultureInfo.InvariantCulture), Selected = true });
        }

        private IEnumerable<SelectListItem> Cidades(int id, int cidadeId)
        {
            return _clienteFacade.GetCidadesPorEstado(id).Where(x => x.Id == cidadeId).Select(x => new SelectListItem { Text = x.Descricao, Value = x.Id.ToString(CultureInfo.InvariantCulture), Selected = true }).Union(Vazio());
        }


    }
}
