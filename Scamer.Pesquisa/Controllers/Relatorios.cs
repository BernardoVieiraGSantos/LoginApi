using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Scamer.Pesquisa.Controllers
{
    [Produces("application/json")]
    [ApiController]
    public class Relatorios : ControllerBase
    {
        // Simulação de banco de dados
        private static readonly List<Relatorio> RelatorioList = new List<Relatorio>
{
    new Relatorio { Id = 1, IdUsuario = 1, Descricao = "Relatório de Vendas", Valor = 100 },
    new Relatorio { Id = 2, IdUsuario = 1, Descricao = "Relatório de Estoque", Valor = 50 },
    new Relatorio { Id = 3, IdUsuario = 2, Descricao = "Relatório Financeiro", Valor = 200 }
};

        // Método para obter relatórios
        [HttpGet("{userId}")]
        public ActionResult<List<Relatorio>> GetRelatorios(int userId)
        {
            return RelatorioList.Where(item => item.IdUsuario == userId).ToList();
        }

    }

    // Modelo de Relatório
    public class Relatorio
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
