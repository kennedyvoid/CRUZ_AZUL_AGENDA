using System;
using System.Data.Entity.ModelConfiguration;

namespace CRUZ_AZUL_AGENDA.Models.Mapping
{
    public class TB_AGENDAMENTOMap : EntityTypeConfiguration<TB_AGENDAMENTO>
    {
        public TB_AGENDAMENTOMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.IdMedico);

            this.Property(t => t.IdPaciente);

            this.Property(t => t.Data);

            this.Property(t => t.Horario);

            this.Property(t => t.DataCadastro);


            // Table & Column Mappings
            this.ToTable("TB_AGENDAMENTO");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IdMedico).HasColumnName("IdMedico");
            this.Property(t => t.IdPaciente).HasColumnName("IdPaciente");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.Horario).HasColumnName("Horario");
            this.Property(t => t.DataCadastro).HasColumnName("DataCadastro");
        }
    }
}