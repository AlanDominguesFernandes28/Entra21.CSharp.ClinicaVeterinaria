namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades
{
    public class Veterinario : EntidadeBase
    {
        public String Nome { get; set; }
        public String Crmv { get; set; }
        public int? Idade { get; set; }
        public decimal? Salario { get; set; }
        public bool Empregado { get; set;} 
    }
}
