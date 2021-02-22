using System;
using System.Data.Entity;
using CRUZ_AZUL_AGENDA.Models.Mapping;

namespace CRUZ_AZUL_AGENDA.Models
{
    public class AgendaContext : DbContext
    { 
        public AgendaContext()
            : base("Name=AgendaContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<TB_AGENDAMENTO> TB_AGENDAMENTO { get; set; }
        public DbSet<TB_MEDICO> TB_MEDICO { get; set; }
        public DbSet<TB_PACIENTE> TB_PACIENTE { get; set; }
        public DbSet<TB_USUARIO> TB_USUARIO { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TB_MEDICOMap());
            modelBuilder.Configurations.Add(new TB_PACIENTEMap());
            modelBuilder.Configurations.Add(new TB_AGENDAMENTOMap());
            modelBuilder.Configurations.Add(new TB_USUARIOMap());
        }
    }

}
