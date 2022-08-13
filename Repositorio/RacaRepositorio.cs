﻿using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio
{
    public class RacaRepositorio : IRacaRepositorio
    {
        private readonly ClinicaVeterinariaContexto _contexto;
        public RacaRepositorio(ClinicaVeterinariaContexto contexto)
        {
            _contexto = contexto;
        }

        public void Apagar(int id)
        {
            var raca = _contexto.Racas.Where(X => X.Id == id).FirstOrDefault();

            _contexto.Racas.Remove(raca);
        }

        public void Atualizar(Raca racaParaAlterar)
        {
            var raca = _contexto.Racas.Where(X => X.Id == racaParaAlterar.Id).FirstOrDefault();

            raca.Nome = racaParaAlterar.Nome; raca.Especie = racaParaAlterar.Especie;

            _contexto.Update(raca);
        }


        public void Cadastrar(Raca raca)
        {
            // INSERT INTO na tabela de racas
            _contexto.Racas.Add(raca);
            _contexto.SaveChanges();
        }

        public Raca ObterPorId(int id)
        {
            var raca = _contexto.Racas.Where(X => X.Id == id).FirstOrDefault();

            return raca;
        }

        public List<Raca> ObterTodos()
        {
            // select * from racas
            //buscar todos os registros de racas
            var racas = _contexto.Racas.ToList();
            return racas;
        }
    }
}