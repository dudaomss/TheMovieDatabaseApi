using TheMovieDatabaseApi.Dto;

namespace TheMovieDatabaseApi.Repository.Interface
{
    public interface IUsuarioRepository
    {
        Task<bool> CriarUsuario(UsuarioDto usuario);
        Task<IEnumerable<UsuarioDto>> ListarUsuario();
    }
}