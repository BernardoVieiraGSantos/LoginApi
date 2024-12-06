using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatoriosAPI.Models
{
    public class LoginResponse
    {
        public bool Success { get; set; } = false;
        public int IdUsuario { get; set; } = 0;
        public string NomeUsuario { get; set; } = "";

    }
}
