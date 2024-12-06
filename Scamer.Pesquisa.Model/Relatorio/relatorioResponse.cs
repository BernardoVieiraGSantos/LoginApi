using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatoriosAPI.Models
{
    public class RelatorioResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }

        public RelatorioResponse(bool success, T data)
        {
            Success = success;
            Data = data;
        }
    }
}
