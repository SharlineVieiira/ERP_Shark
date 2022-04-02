using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Shark
{
    [Table("produto", Schema = "public")]
    public  class DtoProduto
    {
        [Key]
        public int idProduto { get; set; }
        public string descricaoproduto { get; set; }
        public string unidade { get; set; }
        public decimal? valorcusto { get; set; } // ? pode ser nulo
        public decimal? valorvenda { get; set; } // ? pode ser nulo
        public decimal? quantidade { get; set; } // ? pode ser nulo
    }
}
