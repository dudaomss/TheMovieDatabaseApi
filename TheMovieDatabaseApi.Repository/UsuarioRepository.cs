using TheMovieDatabaseApi.Dto;
using TheMovieDatabaseApi.Repository.Interface;

namespace TheMovieDatabaseApi.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public List<UsuarioDto> list = new();

        public async Task<bool> CriarUsuario(UsuarioDto usuario)
        {
            await Task.Delay(1000);
            var existsId = list.Any(x => x.Id == usuario.Id);
            if (existsId) return false;
            list.Add(usuario);
            return true;
        }

        public async Task<IEnumerable<UsuarioDto>> ListarUsuario()
        {
            await Task.Delay(1000);
            return list.AsEnumerable();
        }
    }
}