using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppAkonBD;
using AppAkonBD.Interface;
using AppAkonBD.Modelo;
using AppAkonBD.Repositorios;

namespace AppAkonUI.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IGestorBD _oGestorBD;
        public UsuarioController()
        {
            _oGestorBD = new GestorBD(); //PREGUNTAR al profe cual es la logica de utilizar una interface y no utilzar directamete la misma clase que se esta implementando de la interface
        }
        // GET: Usuario
        public ActionResult ListadoUsuarios()
        {
            List<Usuario> listaUsuarios = _oGestorBD.ListadoUsuarios().ToList(); //como esto es un IEnumerable hay que hacer una conversacion a una lista usando toList
            //IEnumerable<Usuario> listaUsuarios = _oGestorBD.ListadoUsuarios();// O podria hacerlo asi para no hacer la conversion
             
            return View(listaUsuarios);
        }
    }
}