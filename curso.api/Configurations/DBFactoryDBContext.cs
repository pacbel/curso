using curso.api.Infraestruture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Configurations
{/// <summary>
/// 
/// </summary>
    public class DBFactoryDBContext : IDesignTimeDbContextFactory<CursoDbContext>
    {
        private readonly IConfiguration _configuration;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public DBFactoryDBContext(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public CursoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            CursoDbContext contexto = new CursoDbContext(optionsBuilder.Options);
            var migracoespendentes = contexto.Database.GetPendingMigrations();
            if (migracoespendentes.Count() > 0)
            {
                contexto.Database.Migrate();
            }
            return contexto;
        }
    }
}
