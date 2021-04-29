namespace curso.api.Business.Entities
{/// <summary>
/// 
/// </summary>
    public class Curso
    {/// <summary>
    /// 
    /// </summary>
        public int Codigo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CodigoUsuario { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Usuario Usuario { get; set; }

    }
}
