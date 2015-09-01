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


            return View();
        }

        public ActionResult Anfitrioes(int? id)
        {
            if (id == null)
            {
                var clientes = (from b in _clienteFacade.GetTodosClientes()
                                select new { id = b.Id, name = b.Nome });
                return Json(clientes, JsonRequestBehavior.AllowGet);
            }
            return Json(_clienteFacade.GetCliente(id.Value), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Pais()
        {
            var pais = (from b in _clienteFacade.GetPais()
                        select new { id = b.Id, name = b.Descricao });
            return Json(pais, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Estados(int id)
        {
            var estado = (from b in _clienteFacade.GetEstadosPorPais(id)
                          select new { id = b.Id, name = b.Descricao });
            return Json(estado, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Estados2(int id)
        {
            var estado = (from b in _clienteFacade.GetEstadosPorPais(id)
                          select new { id = b.Id, name = b.Descricao });
            return Json(estado, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Cidades(int id)
        {

            var cidade = (from b in _clienteFacade.GetCidadesPorEstado(id)
                          select new { id = b.Id, name = b.Descricao });
            return Json(cidade, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Salvar(Cliente cliente)
        {
            var pais = (from b in _clienteFacade.GetPais()
                        select new { id = b.Id, name = b.Descricao });
            return Json(pais, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {

            return View();
        }





    }
}
