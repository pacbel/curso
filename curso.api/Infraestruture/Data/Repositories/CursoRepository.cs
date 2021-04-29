using curso.api.Business.Entities;
using curso.api.Business.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace curso.api.Infraestruture.Data.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class CursoRepository : ICursoRepository
    {
        private readonly CursoDbContext _contexto;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public CursoRepository(CursoDbContext contexto)
        {
            this._contexto = contexto;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="curso"></param>
        public void AdicionarCurso(Curso curso)
        {
            _contexto.Curso.Add(curso);
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
        /// <param name="codigoUsuario"></param>
        /// <returns></returns>
        public IList<Curso> ObterPorUsuario(int codigoUsuario)
        {
            return _contexto.Curso.Include(i=> i.Usuario).Where(w => w.CodigoUsuario == codigoUsuario).ToList();
        }
    }
}
