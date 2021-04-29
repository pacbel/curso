using curso.api.Business.Entities;
using curso.api.Infraestruture.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Infraestruture.Data
{/// <summary>
/// 
/// </summary>
    public class CursoDbContext : DbContext
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="options"></param>
        public CursoDbContext(DbContextOptions<CursoDbContext> options):base(options)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CursoMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            base.OnModelCreating(modelBuilder);
        }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Usuario> Usuario { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Curso> Curso { get; set; }
    }
}
