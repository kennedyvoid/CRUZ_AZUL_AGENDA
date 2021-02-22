using System;
using System.Data.Entity.ModelConfiguration;

namespace CRUZ_AZUL_AGENDA.Models.Mapping
{
    public class TB_USUARIOMap : EntityTypeConfiguration<TB_USUARIO>
    {
        public TB_USUARIOMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome);

            this.Property(t => t.Email);

            this.Property(t => t.Senha);

            this.Property(t => t.DataCadastro);


            // Table & Column Mappings
            this.ToTable("TB_USUARIO");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Senha).HasColumnName("Senha");
            this.Property(t => t.DataCadastro).HasColumnName("DataCadastro");
        }
    }
}