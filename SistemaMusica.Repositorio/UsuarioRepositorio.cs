using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMusica.Repositorio
{
  public class UsuarioRepositorio
    {
      private SistemaMusicaContexto contexto;

      public UsuarioRepositorio()
      {
          contexto = new SistemaMusicaContexto();
      }

      public void guardarUsuario(Usuario usuario)
      {

          this.contexto.Usuarios.Add(usuario);
          contexto.SaveChanges();
           
      }

      public Usuario validarUsuario(string username, string password)
      {  

          Usuario usuario = contexto.Usuarios.FirstOrDefault(u => u.Username == username && u.Password == password);
          return usuario;
      }


      public Usuario ValidarUsername(string username)
      {
          Usuario usuario = contexto.Usuarios.FirstOrDefault(u => u.Username == username);
          return usuario;
      }

      public void ModificarUsuario(Usuario usuario)
      {
          Usuario usuarioModificar = contexto.Usuarios.FirstOrDefault(u => u.Id == usuario.Id);
          usuarioModificar.Nombres = usuario.Nombres;
          usuarioModificar.Apellidos = usuario.Apellidos;
          usuarioModificar.FechaNacimiento = usuario.FechaNacimiento;
          usuarioModificar.Sexo = usuario.Sexo;
          usuarioModificar.Correo = usuario.Correo;
          usuarioModificar.Username = usuario.Username;
          usuarioModificar.Password = usuario.Password;
          usuarioModificar.TipoUsuario = usuario.TipoUsuario;

          contexto.SaveChanges();

      }

      public void eliminarUsuario(Usuario usuario)
      {
          Usuario usuarioEliminar = contexto.Usuarios.FirstOrDefault(u => u.Id == usuario.Id);
          contexto.Usuarios.Remove(usuarioEliminar);
          contexto.SaveChanges();
      }

    }
}
