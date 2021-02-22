using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUZ_AZUL_AGENDA.Models;
using CRUZ_AZUL_AGENDA.Repository;

namespace CRUZ_AZUL_AGENDA.Controllers
{
    public class MedicoController : Controller
    {
        AgendaRepository repo = new AgendaRepository();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TB_MEDICO medico)
        {
            try
            {
                var result = repo.CadastrarMedico(medico);
                if (result != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Session["Message"] = "Falha ao cadastrar paciente";
                    return RedirectToAction("Index", "Pacientes");
                }

            }
            catch (Exception ex)
            {

                Session["Message"] = ex.Message;
                return RedirectToAction("Index", "Pacientes");
            }
        }
    }
}
