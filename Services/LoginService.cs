using VoeAirlines.Contexts;
using VoeAirlines.Entities;
using VoeAirlines.ViewModels;
using VoeAirlines.ViewModels.Login;

namespace VoeAirlines.Services
{
    public class LoginService
    {
        private readonly VoeAirlinesContext _context;
        public LoginService(VoeAirlinesContext context)
        {
            _context = context;
        }

        public DetalhesLoginViewModel AdicionarLogin(AdicionarLoginViewModel dados) 
        {
            var login = new Login(dados.Usuario, dados.Senha, dados.DataCriacao);

            _context.Add(login);
            _context.SaveChanges();

            return new DetalhesLoginViewModel
            (
                login.Id,
                login.Usuario,
                login.DataCriacao
            );
        }

        //Listar todos os usuários
        public IEnumerable<ListarLoginViewModel> ListarLogin()
        {
            return _context.Logins.Select(l => new ListarLoginViewModel(l.Id, l.Usuario, l.DataCriacao));
        }
        
        //Listar um usuário pelo id
        public DetalhesLoginViewModel ListarLoginPeloId(int id)
        {
            var login = _context.Logins.Find(id);
            if(login == null) {
                return null;
            }
            return new DetalhesLoginViewModel
            (
                login.Id,
                login.Usuario,
                login.DataCriacao
            );
        }
        
        //Deletar um usuário
        public bool DeletarLogin(int id)
        {
            var loginDel = _context.Logins.Find(id);
            if(loginDel == null) {
                return false;
            }

            _context.Logins.Remove(loginDel);
            _context.SaveChanges();
            return true;
        }
        
        //Atualizar um usuário
        public DetalhesLoginViewModel AtualizarLogin(int id, AdicionarLoginViewModel dados)
        {
            var login = _context.Logins.Find(id);
            if(login == null) {
                return null;
            }

            login.Usuario = dados.Usuario;
            login.Senha = dados.Senha;
            login.DataCriacao = dados.DataCriacao;

            _context.Logins.Update(login);
            _context.SaveChanges();
            return new DetalhesLoginViewModel
            (
                login.Id,
                login.Usuario,
                login.DataCriacao
            );
        }
    }
}
