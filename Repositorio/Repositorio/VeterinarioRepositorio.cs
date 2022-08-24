﻿using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Repositorio
{
    public class VeterinarioRepositorio : IVeterinarioRepositorio
    {
        private readonly ClinicaVeterinariaContexto _contexto;
        public VeterinarioRepositorio(ClinicaVeterinariaContexto contexto)
        {
            _contexto = contexto;
        }

        public Veterinario Cadastrar(Veterinario veterinario)
        {
            _contexto.Veterinarios.Add(veterinario);
            _contexto.SaveChanges();

            return veterinario;
        }

        public IList<Veterinario> ObterTodos(string pesquisa) =>
            _contexto.Veterinarios
                // Nome com Like ou CRMV exatamente
                .Where(x => x.Nome.Contains(pesquisa) || x.Crmv == pesquisa)
                .ToList();
    }
}

