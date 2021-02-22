using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUZ_AZUL_AGENDA.Models;
using CRUZ_AZUL_AGENDA.Repository;

namespace CRUZ_AZUL_AGENDA.Controllers
{
    public class CadastroController : Controller
    {
        AgendaRepository repo = new AgendaRepository();

        public ActionResult Index()
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Index(TB_USUARIO usuario)
        {
            try
            {

                TB_USUARIO retorno = repo.Cadastro(usuario);

                if (retorno != null)
                {

                    Session["usuarioLogado"] = retorno;
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
