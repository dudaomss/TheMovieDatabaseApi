using TheMovieDatabaseApi.Dto;

namespace TheMovieDatabaseApi.Business.Interface
{
    public interface IUsuarioBusiness
    {
        Task<bool> CriarUsuario(UsuarioDto usuario);
        Task<IEnumerable<UsuarioDto>> ListarUsuario();
    }
}