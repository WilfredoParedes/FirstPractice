using PracticaRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaRazor.Controllers
{
    public class UsuarioController : Controller
    {
        Prueba1Entities db = new Prueba1Entities();

        public ActionResult Index()
        {
            
            return View(db.Usuarios.ToList());
        }
	}
}