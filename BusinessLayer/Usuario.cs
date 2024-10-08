using commonLayer.Models;
using dataLayer; 
using System.Collections.Generic;

namespace businessLayer
{
    public class Usuario
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarioDAL.ObtenerUsuarios();
        }

        public void AgregarUsuario(Usuario nuevoUsuario)
        {
            // Validación de reglas de negocio
            if (string.IsNullOrEmpty(nuevoUsuario.Nombre) || string.IsNullOrEmpty(nuevoUsuario.Email))
            {
                throw new ArgumentException("El nombre y el email no pueden estar vacíos.");
            }

            usuarioDAL.InsertarUsuario(nuevoUsuario);
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            if (usuario.UsuarioID <= 0)
            {
                throw new ArgumentException("El ID de usuario no es válido.");
            }

            usuarioDAL.ActualizarUsuario(usuario);
        }

        public void EliminarUsuario(int usuarioID)
        {
            if (usuarioID <= 0)
            {
                throw new ArgumentException("El ID de usuario no es válido.");
            }

            usuarioDAL.EliminarUsuario(usuarioID);
        }
    }
}
