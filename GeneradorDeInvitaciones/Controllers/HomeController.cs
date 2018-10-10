using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeneradorDeInvitaciones.Models;

namespace GeneradorDeInvitaciones.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public String index_mod() {

            return "Prueba";
        }

        public ViewResult index() {
            String saludo;
            ViewBag.saludo = "Invitación al taller COMO AMARTE A TI MISMO impartido por " +
                "Marcelo González Pizarro";
            return View();
        }

        public ViewResult RsvpForm() {
            return View();
        }

        [HttpPost] //Metodo post
        public ViewResult RsvpForm(RespuestaInvitado respuestaInvitado) {

            if (ModelState.IsValid)
            {
                return View("Gracias", respuestaInvitado);

            }
            else {

                return View();
            }
        }

    }
}