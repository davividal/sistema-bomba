//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Caixa
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bomba
    {
        public Bomba()
        {
            this.Vendas = new HashSet<Venda>();
        }
    
        public long id { get; set; }
    
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
