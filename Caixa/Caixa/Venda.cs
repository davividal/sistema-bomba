using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Caixa
{
    [Table("vendas")]
    class Venda
    {
        public Venda()
        {
        }

        public int id { get; set; } 
        public Decimal litros { get; set; }
        public long preco_id { get; set; }
        public virtual Preco preco { get; set; }

        public long bomba_id { get; set; }
        public virtual Bomba bomba { get; set; }
    }
}
