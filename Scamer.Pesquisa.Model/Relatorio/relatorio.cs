using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatoriosAPI.Models
{
    public class Relatorio
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string? Descricao { get; set; } // Permitir valor nulo
        public decimal Valor { get; set; }
    }
}
