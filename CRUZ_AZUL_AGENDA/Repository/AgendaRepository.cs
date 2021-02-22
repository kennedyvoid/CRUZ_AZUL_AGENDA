using System;
using System.Collections.Generic;
using System.Linq;
using CRUZ_AZUL_AGENDA.Models;

namespace CRUZ_AZUL_AGENDA.Repository
{
    public class AgendaRepository
    {
        public TB_USUARIO Login(string email, string senha)
        {
            using (AgendaContext db = new AgendaContext())
            {
                var result = db.TB_USUARIO.Where(x => x.Email == email && x.Senha == senha).FirstOrDefault();
                return result;
            }
        }

        public TB_USUARIO Cadastro(TB_USUARIO usuario)
        {
            try
            {
                using (AgendaContext db = new AgendaContext())
                {
                    if (usuario != null)
                    {
                        TB_USUARIO u = db.TB_USUARIO.Where(x => x.Email == usuario.Email).ToList().FirstOrDefault();

                        if (u == null)
                        {
                            usuario.DataCadastro = DateTime.Now;
                            db.TB_USUARIO.Add(usuario);
                            db.SaveChanges();
                            return usuario;
                        }
                        else
                        {
                            return null;
                        }

                    }
                    else
                    {
                        return null;
                    }

                }
            }
            catch (Exception ex)
            {
                return null;

            }
        }

        public List<TB_AGENDAMENTO> CarregarAgendamentos()
        {
            try
            {

                List<TB_AGENDAMENTO> agendamentos;
                using (AgendaContext db = new AgendaContext())
                {

                    agendamentos = db.TB_AGENDAMENTO.ToList();

                    return agendamentos;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public List<TB_PACIENTE> CarregarPacientes()
        {
            try
            {

                List<TB_PACIENTE> pacientes;
                using (AgendaContext db = new AgendaContext())
                {

                    pacientes = db.TB_PACIENTE.ToList();

                    return pacientes;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public List<TB_MEDICO> CarregarMedicos()
        {
            try
            {

                List<TB_MEDICO> medicos;
                using (AgendaContext db = new AgendaContext())
                {

                    medicos = db.TB_MEDICO.ToList();

                    return medicos;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public TB_PACIENTE CadastrarPaciente(TB_PACIENTE paciente)
        {
            try
            {
                using (AgendaContext db = new AgendaContext())
                {
                    if (paciente != null)
                    {
                        TB_PACIENTE p = db.TB_PACIENTE.Where(x => x.Email == paciente.Email).ToList().FirstOrDefault();

                        if (p == null)
                        {
                            paciente.DataCadastro = DateTime.Now;
                            db.TB_PACIENTE.Add(paciente);
                            db.SaveChanges();
                            return paciente;
                        }
                        else
                        {
                            return null;
                        }

                    }
                    else
                    {
                        return null;
                    }

                }
            }
            catch (Exception ex)
            {
                return null;

            }
        }

        public TB_MEDICO CadastrarMedico(TB_MEDICO medico)
        {
            try
            {
                using (AgendaContext db = new AgendaContext())
                {
                    if (medico != null)
                    {
                        TB_MEDICO m = db.TB_MEDICO.Where(x => x.Email == medico.Email).ToList().FirstOrDefault();

                        if (m == null)
                        {
                            medico.DataCadastro = DateTime.Now;
                            db.TB_MEDICO.Add(medico);
                            db.SaveChanges();
                            return medico;
                        }
                        else
                        {
                            return null;
                        }

                    }
                    else
                    {
                        return null;
                    }

                }
            }
            catch (Exception ex)
            {
                return null;

            }
        }
        public TB_AGENDAMENTO CadastrarAgendamento(TB_AGENDAMENTO agendamento)
        {
            try
            {
                using (AgendaContext db = new AgendaContext())
                {
                    if (agendamento != null)
                    {
                        TB_AGENDAMENTO a = db.TB_AGENDAMENTO.Where(x => x.Data == agendamento.Data && x.Horario == agendamento.Horario).ToList().FirstOrDefault();

                        if (a == null)
                        {
                            agendamento.DataCadastro = DateTime.Now;
                            db.TB_AGENDAMENTO.Add(agendamento);
                            db.SaveChanges();
                            return agendamento;
                        }
                        else
                        {
                            return null;
                        }

                    }
                    else
                    {
                        return null;
                    }

                }
            }
            catch (Exception ex)
            {
                return null;

            }
        }

        public bool ExcluirAgendamento(long id)
        {
            try
            {
                using (AgendaContext db = new AgendaContext())
                {
                    if (id > 0)
                    {
                        TB_AGENDAMENTO agendamento = db.TB_AGENDAMENTO.Where(x => x.Id == id).ToList().FirstOrDefault();

                        if (agendamento != null)
                        {
                           
                            db.TB_AGENDAMENTO.Remove(agendamento);
                            db.SaveChanges();
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                return false;

            }
        }

    }
}
