using ApiPeliculas.Data;
using ApiPeliculas.Modelos;
using ApiPeliculas.Modelos.Dtos;
using ApiPeliculas.Repositorio.IRepositorio;

namespace ApiPeliculas.Repositorio;

public class UsuarioRepositorio(MiDbContext _bd) : IUsuarioRepositorio {
    public ICollection<Usuario> GetUsuario() => _bd.Usuarios.ToList().OrderBy(c => c.NombreUsuario).ToList();


    public Usuario GetUsuario(int usuarioid) => _bd.Usuarios.Where(u => u.Id == usuarioid).FirstOrDefault();

    public bool IsUniqueUser(string nombreusuario) {
        var usuario = _bd.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreusuario);
        if (usuario == null) return false; return true;

    }

    public Task<UsuarioLoginRespuestaDto> Login(UsuarioLoginRespuestaDto usuarioLoginRespuestaDto) {
        throw new NotImplementedException();
    }

    public Task<UsuarioDatosDto> Registro(UsuarioDatosDto usuarioDatosDto) {
        throw new NotImplementedException();
    }
}
