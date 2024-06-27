using ApiPeliculas.Modelos;
using ApiPeliculas.Modelos.Dtos;

namespace ApiPeliculas.Repositorio.IRepositorio;

public interface IUsuarioRepositorio {
    ICollection<Usuario> GetUsuario();
    Usuario GetUsuario(int usuarioid);
    bool IsUniqueUser(string usuario);
    Task<UsuarioLoginRespuestaDto> Login(UsuarioLoginRespuestaDto usuarioLoginRespuestaDto);
    Task<UsuarioDatosDto> Registro(UsuarioDatosDto usuarioDatosDto);
   
}
