﻿using TheMovieDatabaseApi.Business.Interface;
using TheMovieDatabaseApi.Dto;
using TheMovieDatabaseApi.Repository.Interface;

namespace TheMovieDatabaseApi.Business
{
    public class UsuarioBusiness : IUsuarioBusiness
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioBusiness(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<bool> CriarUsuario(UsuarioDto usuario)
        {
            try
            {
                return await _usuarioRepository.CriarUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<UsuarioDto>> ListarUsuario()
        {
            try
            {
                return await _usuarioRepository.ListarUsuario();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}