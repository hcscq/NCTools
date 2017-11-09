using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using NCDataMatch.Models.Mapping;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace NCDataMatch.Models
{
    public partial class NCDataMatchContext : DbContext
    {
        static NCDataMatchContext()
        {
            Database.SetInitializer<NCDataMatchContext>(null);
        }

        public NCDataMatchContext()
            : base("Name=NCDataMatchContext")
        {
        }

        public DbSet<BD_MATERIAL> BD_MATERIAL { get; set; }
        public DbSet<IC_SALEOUT_B> IC_SALEOUT_B { get; set; }
        public DbSet<IC_SALEOUT_E> IC_SALEOUT_E { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BD_MATERIALMap());
            modelBuilder.Configurations.Add(new IC_SALEOUT_BMap());
            modelBuilder.Configurations.Add(new IC_SALEOUT_EMap());
        }
        public IEnumerable<TElement> ProcedureQuery<TElement>(string sp)
        {
            string sql = "";
            List<TElement> items = new List<TElement>();



            sql = "EXEC " + sp + " ";
            var tempResult = this.Database.SqlQuery<TElement>(sql);
            if (tempResult != null)
            {
                items.AddRange(tempResult);
            }

            return items;
        }

        public  int ProcedureQuery(string sp, params SqlParameter[] parameters)
        {
            using (var context = this)
            {
                using (context.Database.Connection)
                {
                    context.Database.Connection.Open();
                    var cmd = context.Database.Connection.CreateCommand();
                    cmd.CommandText = sp;
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
