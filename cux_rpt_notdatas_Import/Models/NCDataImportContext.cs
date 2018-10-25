using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using NCDataMatch.Models.Mapping;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace NCDataMatch.Models
{
    public partial class NCDataImportContext : DbContext
    {
        static NCDataImportContext()
        {
            Database.SetInitializer<NCDataImportContext>(null);
        }
        public static string ConnectionString = "";
        public NCDataImportContext()
            : base("Name=NCDataMatchContext")
        {
            Database.Connection.ConnectionString = ConnectionString;
        }

        public DbSet<Cux_Rpt_Notdatas> Cux_Rpt_Notdatas { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Cux_Rpt_notdatasMap());
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
        public int ExecuteNonQuery(string sqlStr)
        {
            //using (var context = this)
            //{

            this.Database.Connection.Open();
            var cmd = this.Database.Connection.CreateCommand();
            cmd.CommandText = sqlStr;
            cmd.CommandType = CommandType.Text;
            int re = cmd.ExecuteNonQuery();
            this.Database.Connection.Close();
            return re;

            //}
        }
    }
}
