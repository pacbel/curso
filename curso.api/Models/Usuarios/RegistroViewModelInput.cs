using System.ComponentModel.DataAnnotations;

namespace curso.api.Models.Usuarios
{/// <summary>
/// 
/// </summary>
    public class RegistroViewModelInput
    {/// <summary>
    /// 
    /// </summary>
        [Required(ErrorMessage = "O Login é obrigatório")]
        public string Login { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "O E-mail é obrigatório")]
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "A Senha é obrigatória")]
        public string Senha { get; set; }
    }
}
