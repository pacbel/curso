using curso.api.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Configurations
{/// <summary>
/// 
/// </summary>
    public interface IAuthenticationService
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="usuarioViewModelOutput"></param>
    /// <returns></returns>
        string GerarToken(UsuarioViewModelOutput usuarioViewModelOutput);
    }
}
