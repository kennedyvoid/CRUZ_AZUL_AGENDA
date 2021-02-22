using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using CRUZ_AZUL_AGENDA.Models;
using CRUZ_AZUL_AGENDA.Repository;
using PagedList;

namespace CRUZ_AZUL_AGENDA.Controllers
{

    public class HomeController : Controller
    {
        AgendaRepository repo = new AgendaRepository();

        public ActionResult Index(int? pagina)
        {
            if (Session["usuarioLogado"] != null)
            {

                List<TB_AGENDAMENTO> agendamento = repo.CarregarAgendamentos();

                int tamanhoPagina = 10;
                int numeroPagina = pagina ?? 1;

                return View(agendamento.OrderBy(x => x.Data).ToPagedList(numeroPagina, tamanhoPagina));
            }
            else
            {

                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult NovoAgendamento()
        {

            List<TB_MEDICO> medicos = repo.CarregarMedicos();
            List<TB_PACIENTE> pacientes = repo.CarregarPacientes();

            var model = new AgendamentoViewModel
            {
                medicos = medicos,
                pacientes = pacientes
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult NovoAgendamento(AgendamentoViewModel agendamentoViewModel)
        {
            try
            {
                var result = repo.CadastrarAgendamento(agendamentoViewModel.agendamento);
                if (result != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Session["Message"] = "Erro ao registrar agendamento, verifique a disponibilidade do horario!";
                    return RedirectToAction("Index", "Pacientes");
                }

            }
            catch (Exception ex)
            {

                Session["Message"] = ex.Message;
                return RedirectToAction("NovoAgendamento", "Home");
            }
        }

        public ActionResult ExcluirAgendamento(long id)
        {
            try
            {
                var result = repo.ExcluirAgendamento(id);
                if (result)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Session["Message"] = "Erro ao excluir agendamento!";
                    return RedirectToAction("Index", "Home");
                }

            }
            catch (Exception ex)
            {

                Session["Message"] = ex.Message;
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
