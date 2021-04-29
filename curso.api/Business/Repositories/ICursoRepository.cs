using curso.api.Business.Entities;
using System.Collections.Generic;

namespace curso.api.Business.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICursoRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="curso"></param>
        void AdicionarCurso(Curso curso);
        /// <summary>
        /// 
        /// </summary>
        void Commit();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigoUsuario"></param>
        /// <returns></returns>
        IList<Curso> ObterPorUsuario(int codigoUsuario);

    }
}
