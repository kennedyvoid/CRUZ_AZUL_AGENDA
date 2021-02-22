using System;
using System.ComponentModel.DataAnnotations;

namespace CRUZ_AZUL_AGENDA.Models
{
    public class TB_USUARIO
    {
        [Key]
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
