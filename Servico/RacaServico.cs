using Entra21.CSharp.ClinicaVeterinaria.Repositorio;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico
{
    // A classe RacaServico irá implementar a interface IRacaServico,
    // ou seja, deverá honrar as clausulas definidos no interface(contrato)
    public class RacaServico : IRacaServico
    {
        private RacaRepositorio _racaRepositorio;

        // Construtor: Construir de racaServiço com o minimo para a correta execução
        public RacaServico(ClinicaVeterinariaContexto contexto)
        {
            _racaRepositorio = new RacaRepositorio(contexto);
        }

        public void Cadastrar(string nome, string especie)
        {
            var raca = new Raca();
            raca.Nome = nome;
            raca.Especie = especie;

            _racaRepositorio.Cadastrar(raca);

            Console.WriteLine($"Nome: {nome} Espécie: {especie}");

        }
        public void Alterar (int id,string nome,string especie)
        {
            var raca = new Raca();
            raca.Id = id;
            raca.Nome = nome.Trim();
            raca.Especie = especie;

            _racaRepositorio.Atualizar(raca);
        }
        public void Apagar(int id)
        {
            _racaRepositorio.Apagar(id);
        }
        public Raca ObterPorId(int id)
        {
            var raca = _racaRepositorio.ObterPorId(id);

            return raca;
        }
        public List<Raca> ObterTodos()
        {
            var racasDoBanco = _racaRepositorio.ObterTodos();

            return racasDoBanco;
        }
    }
}
