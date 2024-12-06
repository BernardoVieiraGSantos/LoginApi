using Microsoft.AspNetCore.Mvc;
using RelatoriosAPI.Models;
using Renci.SshNet.Messages;
using Scamer.Pesquisa.Model;

// Importação do namespace correto
using System.Collections.Generic;
using System.Linq;

namespace Scamer.Pesquisa.Controllers
{
    [Produces("application/json")]
    [ApiController]
    public class loginController : ControllerBase
    {
        private static readonly List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario { Id = 1, Nome = "Bernardo", Login = "admin", Senha = "admin" },
            new Usuario { Id = 2, Nome = "Bernardo", Login = "bernardo", Senha = "admin" }
        };

        Usuario? VerificaUsuario(LoginRequest loginRequest)
        {
            return usuarios.Find(x => x.Login == loginRequest.Usuario && x.Senha == loginRequest.Senha);
        }

        [HttpPost("autenticar")]
        public LoginResponse Login([FromBody] LoginRequest loginRequest)
        {
            LoginResponse objLogin = new LoginResponse();
            Usuario objLstUsuarios = new Usuario();

            try
            {
                var usr = VerificaUsuario(loginRequest);
                if (usr != null)
                {
                    objLogin.NomeUsuario = usr.Nome;
                    objLogin.Success = true;
                    objLogin.IdUsuario = usr.Id;

                    return objLogin;
                }
                return objLogin;
            }
            catch (Exception ex)
            {

                return objLogin;
            }
        }
    }
}
