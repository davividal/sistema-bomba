using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Caixa
{
    [Table("precos")] 
    class Preco
    {
        public int id { get; set; } 
        public Decimal valor { get; set; }
        public String data { get; set; }
    }
}
