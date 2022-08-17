using Entra21.CSharp.ClinicaVeterinaria.Repositorio;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico
{
    // A classe RacaServico irá implementar a interface IRacaServico,
    // ou seja, deverá honrar as clausulas definidos no interface(contrato)
    public class RacaServico : IRacaServico
    {
        private RacaRepositorio _racasRepositorio;

        // Construtor: Construir de racaServiço com o minimo para a correta execução
        public RacaServico(ClinicaVeterinariaContexto contexto)
        {
            _racasRepositorio = new RacaRepositorio(contexto);
        }

        public void Alterar(int id, string nome, string especie)
        {
            var raca = new Raca();
            raca.Id = id;
            raca.Nome = nome;
            raca.Especie = especie;

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

        public void Cadastrar(string nome, string especie)
        {
            var raca = new Raca();
            raca.Nome = nome;
            raca.Especie = especie;

            _racasRepositorio.Cadastrar(raca);

            Console.WriteLine($"Nome: {nome} Espécie: {especie}");
        }

        public List<Raca> ObterTodos()
        {
            var racasDoBanco = _racasRepositorio.ObterTodos();

            return racasDoBanco;
        }
    }
}
