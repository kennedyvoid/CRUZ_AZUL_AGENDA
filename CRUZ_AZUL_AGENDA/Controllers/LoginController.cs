using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUZ_AZUL_AGENDA.Models;
using CRUZ_AZUL_AGENDA.Repository;

namespace CRUZ_AZUL_AGENDA.Controllers
{
    public class LoginController : Controller
    {
        AgendaRepository repo = new AgendaRepository();
        // GET: Login
        public ActionResult Index()
        {
            Session["usuarioLogado"] = null;
            return View();
        }

        [HttpPost]
        public ActionResult Index(TB_USUARIO usuario)
        {
            try
            {
                var result = repo.Login(usuario.Email, usuario.Senha);
                if (result != null)
                {

                    Session["usuarioLogado"] = result;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Session["Message"] = "Falha ao realizar login";
                    return RedirectToAction("Index", "Login");
                }

            }
            catch (Exception ex)
            {

                Session["Message"] = ex.Message;
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
