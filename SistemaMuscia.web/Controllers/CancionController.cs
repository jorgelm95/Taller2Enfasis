using SistemaMusica.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaMuscia.web.Controllers
{
    public class CancionController : Controller
    {
        // GET: Cancion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GuardarCancion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GuardarCancion(Cancion cancion)
        {
            CancionRepositorio RepoCancion = new CancionRepositorio();
            RepoCancion.GuardarCancion(cancion);
            return View();
        }

        public ActionResult ListarCanciones()
        {
            CancionRepositorio repo = new CancionRepositorio();
            List<Cancion> listaCanciones =  repo.canciones();
            return PartialView(listaCanciones);
        }
    }
}