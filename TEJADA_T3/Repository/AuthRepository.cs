using System.Collections.Generic;
using System.Linq;
using TEJADA_T3.Models;

namespace TEJADA_T3.Repository
{
    public interface IAuthRepository
    {
        Usuario GetUsuario(string username, string password);
        void SaveUsuario(Usuario user);
        List<Usuario> GetUsuarios();
    }
    public class AuthRepository : IAuthRepository
    {
        private readonly Context context;

        public AuthRepository(Context context)
        {
            this.context = context;
        }

        public Usuario GetUsuario(string username, string password)
        {
            return context.Usuarios.Where(o => o.Username == username && o.Password == password).FirstOrDefault();
        }

        public List<Usuario> GetUsuarios()
        {
            return context.Usuarios.ToList();
        }

        public void SaveUsuario(Usuario user)
        {
            context.Usuarios.Add(user);
            context.SaveChanges();
        }
    }
}
