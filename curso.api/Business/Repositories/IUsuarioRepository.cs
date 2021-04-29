using curso.api.Business.Entities;

namespace curso.api.Business.Repositories
{/// <summary>
/// 
/// </summary>
    public interface IUsuarioRepository
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="usuario"></param>
        void Adicionar(Usuario usuario);
        /// <summary>
        /// 
        /// </summary>
        void Commit();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        Usuario ObterUsuario(string login);
    }
}
