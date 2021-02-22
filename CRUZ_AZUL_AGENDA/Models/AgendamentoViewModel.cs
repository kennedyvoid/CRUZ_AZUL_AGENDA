using System;
using System.Collections.Generic;

namespace CRUZ_AZUL_AGENDA.Models
{
    public class AgendamentoViewModel
    {
        public List<TB_MEDICO> medicos { get; set; }
        public List<TB_PACIENTE> pacientes { get; set; }
        public TB_AGENDAMENTO agendamento { get; set; }
    }
}
