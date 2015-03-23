using SistemaMusica.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaMuscia.web.Controllers
{
    public class ArtistaController : Controller
    {
        // GET: Artista
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GuardarArtista()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GuardarArtista(Artista artiista)
        {
            ArtistaRepositorio artistaRepo = new ArtistaRepositorio();

            artistaRepo.GuardarArtista(artiista);
            ViewBag.Artista = "artista publicado con exito";
            return View();


        }

    }
}