using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Mapeamentos;
using Microsoft.EntityFrameworkCore;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados
{
    public class ClinicaVeterinariaContexto : DbContext
    {
        public DbSet<Raca> Racas { get; set; }

        public ClinicaVeterinariaContexto(
            DbContextOptions<ClinicaVeterinariaContexto> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // documentacao:https://docs.microsoft.com/pt-br/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
            // necessario instalar a ferramenta do dotnet ef core
            //  dotnet tool install --global dotnet-ef

            //1 etapa criar a entidade
            //2 etapa criar o mapeamento da entidade para tabela
            //3 etapa registrar o mapeamento
            //4 etapa gerar a migration
            //5 etapa a migration podera ser aplicada de duas formas:
            //         executar comando para aplicas a migration sem a
            //           necessidade de executar a aplicacao
            //           dotnet ef database update
            //         executar a aplicacao ira ampliar a migration

            modelBuilder.ApplyConfiguration(new RacaMapeamento());
        }
    }
}
