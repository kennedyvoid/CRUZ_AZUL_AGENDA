using System;
using System.ComponentModel.DataAnnotations;

namespace CRUZ_AZUL_AGENDA.Models
{
    public class TB_AGENDAMENTO
    {
        [Key]
        public long Id { get; set; }
        public long IdMedico { get; set; }
        public long IdPaciente { get; set; }
        public DateTime Data { get; set; }
        public string Horario { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
