using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models
{/// <summary>
/// 
/// </summary>
    public class ValidaCampoViewModelOutput
    {/// <summary>
    /// 
    /// </summary>
        public IEnumerable<string> Erros { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="erros"></param>
        public ValidaCampoViewModelOutput(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}
