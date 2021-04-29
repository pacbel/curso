using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Usuarios
{/// <summary>
/// 
/// </summary>
    public class LoginViewModelInput
    {/// <summary>
    /// 
    /// </summary>
        [Required(ErrorMessage = "O Login é obrigatório")]
        public string Login { get; set; }
/// <summary>
/// 
/// </summary>
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; }
    }
}
