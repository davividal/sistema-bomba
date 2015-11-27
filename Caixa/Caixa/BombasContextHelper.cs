using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caixa
{
    class BombasContextHelper
    {
        public BombasContextHelper()
        {
            Migrations = new Dictionary<int, IList>();
 
            MigrationVersion1();
        }
 
        public Dictionary<int, IList> Migrations { get; set; }
 
        private void MigrationVersion1()
        {
            IList steps = new List<String>(); 
            Migrations.Add(1, steps);
        }
    }
}
