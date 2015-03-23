using SistemaMusica.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaMuscia.web.Controllers
{
    public class UsuarioController : Controller
    {
        
        
        public UsuarioController()
        {
            
        }

        // GET: Usuario
        public ActionResult Index()
        {
            Usuario usuario = Session["usuarioLogueado"] as Usuario;
            ViewBag.NombreUsuario = usuario.Nombres;
            return View();
        }

        public ActionResult GuardarUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GuardarUsuario(Usuario usuario)
        {
            UsuarioRepositorio repositorioUsuario = new UsuarioRepositorio();
            string username = usuario.Username;
            Usuario usernameValidar = repositorioUsuario.ValidarUsername(username);

            if (usernameValidar == null)
            {
                repositorioUsuario.guardarUsuario(usuario);
                ViewBag.UsuarioCreado = "Su registro se completo satisfactoriamente";
                return  RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.UsernameDuplicado = "El username ya existe escoja otro";
                return RedirectToAction("Index", "Home");
   
            }
        }


        public ActionResult validarUsuario(string username, string password)
        {
            UsuarioRepositorio repo = new UsuarioRepositorio();


            Usuario usuarioValidado = repo.validarUsuario(username, password);
            if (usuarioValidado == null)
            {
                ViewBag.MensajeError = "El usuario no exixte, intente nuevamente";
                return View("Login");
            }
            else
            {
               Session["usuarioLogueado"] = usuarioValidado;
                return RedirectToAction("Index");
            }
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}