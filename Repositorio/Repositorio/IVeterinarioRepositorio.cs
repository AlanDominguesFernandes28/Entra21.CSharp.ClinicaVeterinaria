using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Repositorio
{
    public interface IVeterinarioRepositorio
    {
        Veterinario Cadastrar(Veterinario veterinario);
        IList<Veterinario> ObterTodos(string pesquisa);
    }
}
