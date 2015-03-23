using SistemaMusica.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaMuscia.web.Controllers
{
    public class DiscoController : Controller
    {
        // GET: Disco
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GuardarDisco()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GuardarDisco(Disco disco)
        {

            DiscoRepositorio discoRepo = new  DiscoRepositorio();
            discoRepo.GuardarDisco(disco);
            return View();
        }
    }
}