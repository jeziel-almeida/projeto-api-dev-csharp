namespace VoeAirlines.ViewModels
{
    public class AdicionarLoginViewModel
    {

        public AdicionarLoginViewModel(string? usuario, string? senha, DateTime dataCriacao)
        {
            Usuario = usuario;
            Senha = senha;
            DataCriacao = dataCriacao;
        }
        public string? Usuario { get; set; }
        public string? Senha { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}