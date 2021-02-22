using System;
using System.Data.Entity.ModelConfiguration;

namespace CRUZ_AZUL_AGENDA.Models.Mapping
{
    public class TB_MEDICOMap : EntityTypeConfiguration<TB_MEDICO>
    {
        public TB_MEDICOMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome);

            this.Property(t => t.Documento);

            this.Property(t => t.CRM);

            this.Property(t => t.Email);

            this.Property(t => t.Telefone);

            this.Property(t => t.DataCadastro);


            // Table & Column Mappings
            this.ToTable("TB_MEDICO");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Documento).HasColumnName("Documento");
            this.Property(t => t.CRM).HasColumnName("CRM");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Telefone).HasColumnName("Telefone");
            this.Property(t => t.DataCadastro).HasColumnName("DataCadastro");
        }
    }
}