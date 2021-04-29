using curso.api.Infraestruture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Configurations
{/// <summary>
/// 
/// </summary>
    public class DBFactoryDBContext : IDesignTimeDbContextFactory<CursoDbContext>
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
        public CursoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=CURSO;user=sa;password=p4ch3c0");
            CursoDbContext contexto = new CursoDbContext(optionsBuilder.Options);
            return contexto;
        }
    }
}
