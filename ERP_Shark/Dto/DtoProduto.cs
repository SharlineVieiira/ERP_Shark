using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Shark
{
    public  class DtoProduto
    {
        public int Reduzido { get; set; }
        public string DescricaoProduto { get; set; }
        public string Unidade { get; set; }
        public decimal? ValorCusto { get; set; } // ? pode ser nulo
        public decimal? ValorVenda { get; set; } // ? pode ser nulo
        public decimal? Quantidade { get; set; } // ? pode ser nulo
    }
}
