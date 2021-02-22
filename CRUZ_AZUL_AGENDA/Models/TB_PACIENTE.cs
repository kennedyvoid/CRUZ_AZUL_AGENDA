using System;
using System.ComponentModel.DataAnnotations;

namespace CRUZ_AZUL_AGENDA.Models
{
    public class TB_PACIENTE
    {
        [Key]
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Documento { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}