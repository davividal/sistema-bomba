using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Caixa
{
    [Table("bombas")]
    class Bomba
    {
        public int id { get; set; } 

        /*public long ArtistId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Album> Albums { get; set; }*/
    }
}
