using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Mapeamentos
{
    //DB first: criar um aplicacao onde o banco de dados existente
    // Code First: criar um banco de dados a apartir de uma aplicacao existente
    // Seed: alimentar o banco de dados com registros
    // Migration: representacao do mapeamento que sera aplicado no banco de dados
    // mapeamento: representacao da entidade em tabelas,colunas,indices
    internal class RacaMapeamento : IEntityTypeConfiguration<Raca>
    {

        public void Configure(EntityTypeBuilder<Raca> builder)
        {
            builder.ToTable("racas");

            builder.HasKey(X => X.Id).HasName("id");

      
            builder.Property(X => X.Especie)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("especie"); //not full

            builder.Property(X => X.Nome)
              .HasColumnType("VARCHAR")
              .HasMaxLength(30)
              .IsRequired()
              .HasColumnName("nome");

            builder.HasData(new Raca
            {
                Id=1,
                Nome = "Frajola",
                Especie = "Gato"
            },

            new Raca
            {
                Id=2,
                Nome = "Piupiu",
                Especie = "Capivara"
            });


        }  
    }
}
