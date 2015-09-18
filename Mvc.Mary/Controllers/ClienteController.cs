﻿using System.Collections;
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
            return id == null ? Json(_clienteFacade.GetTodosClientesSelect(), JsonRequestBehavior.AllowGet) 
                              : Json(_clienteFacade.GetCliente(id.Value), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Paiz()
        {
            return Json( _clienteFacade.GetPaizSelect(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Estados(int id)
        {
            return Json(_clienteFacade.GetEstadosPorPaizSelect(id), JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult Cidades(int id)
        {
            return Json(_clienteFacade.GetCidadesPorEstadoSelect(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Salvar(Cliente cliente)
        {
            return Json(_clienteFacade.GetPaizSelect(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            return View();
        }

    }
}
