using Entra21.CSharp.ClinicaVeterinaria.Repositorio;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModel;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico
{
    // A classe RacaServico irá implementar a interface IRacaServico,
    // ou seja, deverá honrar as clausulas definidos no interface(contrato)
    public class RacaServico : IRacaServico
    {
        private IRacaRepositorio _racasRepositorio;

        // Construtor: Construir de racaServiço com o minimo para a correta execução
        public RacaServico(ClinicaVeterinariaContexto contexto)
        {
            _racasRepositorio = new RacaRepositorio(contexto);
        }

        public void Editar(RacaEditarViewModel racaEditarViewModel)
        {
            var raca = new Raca();
            raca.Id = racaEditarViewModel.Id;
            raca.Nome = racaEditarViewModel. Nome.Trim();
            raca.Especie = racaEditarViewModel.Especie;

            _racasRepositorio.Atualizar(raca);
        }

        public void Apagar(int id)
        {
            _racasRepositorio.Apagar(id);
        }

        public Raca ObterPorId(int id)
        {
            var raca = _racasRepositorio.ObterPorId(id);

            return raca;
        }

        public void Cadastrar(RacaCadastrarViewModel racaCadastrarViewModel)
        {
            var raca = new Raca();
            raca.Nome = racaCadastrarViewModel.Nome;
            raca.Especie = racaCadastrarViewModel.Especie;

            _racasRepositorio.Cadastrar(raca);
        }

        public List<Raca> ObterTodos()
        {
            var racasDoBanco = _racasRepositorio.ObterTodos();

            return racasDoBanco;
        }
    }
}
