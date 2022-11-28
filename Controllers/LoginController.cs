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
    }
}