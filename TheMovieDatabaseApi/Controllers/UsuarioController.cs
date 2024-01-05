using Microsoft.AspNetCore.Mvc;
using TheMovieDatabaseApi.Business;
using TheMovieDatabaseApi.Business.Interface;
using TheMovieDatabaseApi.Dto;

namespace TheMovieDatabaseApi.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioBusiness _usuarioBusiness;
        public UsuarioController(UsuarioBusiness usuarioBusiness)
        {
            _usuarioBusiness = usuarioBusiness;
        }

        [HttpPost("criar-usuario")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CriarUsuario(
            [FromBody] UsuarioDto usuario
        )
        {
            var usuarioCriado = await _usuarioBusiness.CriarUsuario(usuario);
            return usuarioCriado ? Ok(usuarioCriado) : BadRequest("Nao foi possivel criar usuario.");
        }

        [HttpGet("listar-usuario")]
        [ProducesResponseType(typeof(IEnumerable<UsuarioDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListarUsuario()
        {
            var listagemUsuario = await _usuarioBusiness.ListarUsuario();
            return listagemUsuario.Any() ? Ok(listagemUsuario) : NoContent();
        }
    }
}
