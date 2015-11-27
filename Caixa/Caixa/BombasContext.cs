using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa
{
    class BombasContext : DbContext
    {
        public static int RequiredDatabaseVersion = 1;
        public DbSet<Bomba> Bombas { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Preco> Precos { get; set; }
        public DbSet<SchemaInfo> SchemaInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions
                .Remove<IncludeMetadataConvention>();
        }

        public void Initialize()
        {
            using (BombasContext context = new BombasContext())
            {
                int currentVersion = 0;
                if (context.SchemaInfoes.Count() > 0)
                    currentVersion = context.SchemaInfoes.Max(x => x.Version);
                BombasContextHelper mmSqliteHelper = new BombasContextHelper();
                while (currentVersion < RequiredDatabaseVersion)
                {
                    currentVersion++;
                    foreach (string migration in mmSqliteHelper.Migrations[currentVersion])
                    {
                        context.Database.ExecuteSqlCommand(migration);
                    }
                    context.SchemaInfoes.Add(new SchemaInfo() { Version = currentVersion });
                    context.SaveChanges();
                }
            }

        }
    }
}
