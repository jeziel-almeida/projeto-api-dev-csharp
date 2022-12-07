using VoeAirlines.Services;
using VoeAirlines.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace VoeAirlines.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _loginService;
        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult AdicionarLogin(AdicionarLoginViewModel dados)
        {
            var login = _loginService.AdicionarLogin(dados);
            //return CreatedAtAction(nameof(ListarLoginPeloId), new { id = login.Id }, login);
            return Ok(login);
        }

        [HttpGet]
        public IActionResult ListarLogins()
        {
            return Ok(_loginService.ListarLogin());
        }
        
        [HttpGet("{id}")]
        public IActionResult ListarLoginPeloId(int id)
        {
            var login = _loginService.ListarLoginPeloId(id);
            if(login == null) {
                return NotFound("Login não encontrado!");
            }
            return Ok(login);
        }
        
        [HttpDelete("{id}")]
        public IActionResult DeletarLogin(int id)
        {
            var sucesso = _loginService.DeletarLogin(id);
            if(!sucesso) {
                return NotFound("Login não encontrado!");
            }
            return Ok("Deletado com sucesso!");
        }
        
        [HttpPut("{id}")]
        public IActionResult AtualizarLogin(int id, AdicionarLoginViewModel dados)
        {
            var login = _loginService.AtualizarLogin(id, dados);
            if(login == null) {
                return NotFound("Login não encontrado!");
            }
            return Ok(login);
        }
    }
}
