using curso.api.Business.Entities;
using curso.api.Business.Repositories;
using System.Linq;

namespace curso.api.Infraestruture.Data.Repositories
{/// <summary>
/// 
/// </summary>
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly CursoDbContext _contexto;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public UsuarioRepository(CursoDbContext contexto)
        {
            _contexto = contexto;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        public void Adicionar(Usuario usuario)
        {
            _contexto.Usuario.Add(usuario);
        }
        /// <summary>
        /// 
        /// </summary>
        public void Commit()
        {
            _contexto.SaveChanges();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public Usuario ObterUsuario(string login)
        {
            return _contexto.Usuario.FirstOrDefault(u => u.Login == login);
        }
    }
}
