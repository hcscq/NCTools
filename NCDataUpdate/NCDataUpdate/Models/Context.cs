using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using NCDataUpdate.Models.Mapping;

namespace NCDataUpdate.Models
{
    public partial class Context : DbContext
    {
        static Context()
        {
            Database.SetInitializer<Context>(null);
        }

        public Context()
            : base("Name=Context")
        {
        }

        public DbSet<OUT_OTHER_CL> OUT_OTHER_CL { get; set; }
        public DbSet<R_CLUSTER> R_CLUSTER { get; set; }
        public DbSet<R_CLUSTER_SLAVE> R_CLUSTER_SLAVE { get; set; }
        public DbSet<R_CONDITION> R_CONDITION { get; set; }
        public DbSet<R_DATABASE> R_DATABASE { get; set; }
        public DbSet<R_DATABASE_ATTRIBUTE> R_DATABASE_ATTRIBUTE { get; set; }
        public DbSet<R_DATABASE_CONTYPE> R_DATABASE_CONTYPE { get; set; }
        public DbSet<R_DATABASE_TYPE> R_DATABASE_TYPE { get; set; }
        public DbSet<R_DEPENDENCY> R_DEPENDENCY { get; set; }
        public DbSet<R_DIRECTORY> R_DIRECTORY { get; set; }
        public DbSet<R_JOB> R_JOB { get; set; }
        public DbSet<R_JOB_ATTRIBUTE> R_JOB_ATTRIBUTE { get; set; }
        public DbSet<R_JOB_HOP> R_JOB_HOP { get; set; }
        public DbSet<R_JOB_LOCK> R_JOB_LOCK { get; set; }
        public DbSet<R_JOBENTRY> R_JOBENTRY { get; set; }
        public DbSet<R_JOBENTRY_ATTRIBUTE> R_JOBENTRY_ATTRIBUTE { get; set; }
        public DbSet<R_JOBENTRY_COPY> R_JOBENTRY_COPY { get; set; }
        public DbSet<R_JOBENTRY_TYPE> R_JOBENTRY_TYPE { get; set; }
        public DbSet<R_LOG> R_LOG { get; set; }
        public DbSet<R_LOGLEVEL> R_LOGLEVEL { get; set; }
        public DbSet<R_NOTE> R_NOTE { get; set; }
        public DbSet<R_PARTITION> R_PARTITION { get; set; }
        public DbSet<R_PARTITION_SCHEMA> R_PARTITION_SCHEMA { get; set; }
        public DbSet<R_REPOSITORY_LOG> R_REPOSITORY_LOG { get; set; }
        public DbSet<R_SLAVE> R_SLAVE { get; set; }
        public DbSet<R_STEP> R_STEP { get; set; }
        public DbSet<R_STEP_ATTRIBUTE> R_STEP_ATTRIBUTE { get; set; }
        public DbSet<R_STEP_TYPE> R_STEP_TYPE { get; set; }
        public DbSet<R_TRANS_ATTRIBUTE> R_TRANS_ATTRIBUTE { get; set; }
        public DbSet<R_TRANS_CLUSTER> R_TRANS_CLUSTER { get; set; }
        public DbSet<R_TRANS_HOP> R_TRANS_HOP { get; set; }
        public DbSet<R_TRANS_LOCK> R_TRANS_LOCK { get; set; }
        public DbSet<R_TRANS_PARTITION_SCHEMA> R_TRANS_PARTITION_SCHEMA { get; set; }
        public DbSet<R_TRANS_SLAVE> R_TRANS_SLAVE { get; set; }
        public DbSet<R_TRANSFORMATION> R_TRANSFORMATION { get; set; }
        public DbSet<R_USER> R_USER { get; set; }
        public DbSet<R_VALUE> R_VALUE { get; set; }
        public DbSet<R_VERSION> R_VERSION { get; set; }
        public DbSet<SO_MIDDLE_SALEORDER> SO_MIDDLE_SALEORDER { get; set; }
        public DbSet<SO_MIDDLE_SALEORDER_B> SO_MIDDLE_SALEORDER_B { get; set; }
        public DbSet<UAPBD_MID_DISCARDOUT_B> UAPBD_MID_DISCARDOUT_B { get; set; }
        public DbSet<UAPBD_MID_GENERALOUT_B> UAPBD_MID_GENERALOUT_B { get; set; }
        public DbSet<UAPBD_MID_INVCOUNT_B> UAPBD_MID_INVCOUNT_B { get; set; }
        public DbSet<UAPBD_MID_MATERIAL> UAPBD_MID_MATERIAL { get; set; }
        public DbSet<UAPBD_MID_RECBILL> UAPBD_MID_RECBILL { get; set; }
        public DbSet<UAPBD_MID_TRANSFORM_B> UAPBD_MID_TRANSFORM_B { get; set; }
        public DbSet<UAPBD_MID_WHSTRAN_B> UAPBD_MID_WHSTRAN_B { get; set; }

        public DbSet<DBASE_ITEM_MSG_ORG> DBASE_ITEM_MSG_ORG { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OUT_OTHER_CLMap());
            modelBuilder.Configurations.Add(new R_CLUSTERMap());
            modelBuilder.Configurations.Add(new R_CLUSTER_SLAVEMap());
            modelBuilder.Configurations.Add(new R_CONDITIONMap());
            modelBuilder.Configurations.Add(new R_DATABASEMap());
            modelBuilder.Configurations.Add(new R_DATABASE_ATTRIBUTEMap());
            modelBuilder.Configurations.Add(new R_DATABASE_CONTYPEMap());
            modelBuilder.Configurations.Add(new R_DATABASE_TYPEMap());
            modelBuilder.Configurations.Add(new R_DEPENDENCYMap());
            modelBuilder.Configurations.Add(new R_DIRECTORYMap());
            modelBuilder.Configurations.Add(new R_JOBMap());
            modelBuilder.Configurations.Add(new R_JOB_ATTRIBUTEMap());
            modelBuilder.Configurations.Add(new R_JOB_HOPMap());
            modelBuilder.Configurations.Add(new R_JOB_LOCKMap());
            modelBuilder.Configurations.Add(new R_JOBENTRYMap());
            modelBuilder.Configurations.Add(new R_JOBENTRY_ATTRIBUTEMap());
            modelBuilder.Configurations.Add(new R_JOBENTRY_COPYMap());
            modelBuilder.Configurations.Add(new R_JOBENTRY_TYPEMap());
            modelBuilder.Configurations.Add(new R_LOGMap());
            modelBuilder.Configurations.Add(new R_LOGLEVELMap());
            modelBuilder.Configurations.Add(new R_NOTEMap());
            modelBuilder.Configurations.Add(new R_PARTITIONMap());
            modelBuilder.Configurations.Add(new R_PARTITION_SCHEMAMap());
            modelBuilder.Configurations.Add(new R_REPOSITORY_LOGMap());
            modelBuilder.Configurations.Add(new R_SLAVEMap());
            modelBuilder.Configurations.Add(new R_STEPMap());
            modelBuilder.Configurations.Add(new R_STEP_ATTRIBUTEMap());
            modelBuilder.Configurations.Add(new R_STEP_TYPEMap());
            modelBuilder.Configurations.Add(new R_TRANS_ATTRIBUTEMap());
            modelBuilder.Configurations.Add(new R_TRANS_CLUSTERMap());
            modelBuilder.Configurations.Add(new R_TRANS_HOPMap());
            modelBuilder.Configurations.Add(new R_TRANS_LOCKMap());
            modelBuilder.Configurations.Add(new R_TRANS_PARTITION_SCHEMAMap());
            modelBuilder.Configurations.Add(new R_TRANS_SLAVEMap());
            modelBuilder.Configurations.Add(new R_TRANSFORMATIONMap());
            modelBuilder.Configurations.Add(new R_USERMap());
            modelBuilder.Configurations.Add(new R_VALUEMap());
            modelBuilder.Configurations.Add(new R_VERSIONMap());
            modelBuilder.Configurations.Add(new SO_MIDDLE_SALEORDERMap());
            modelBuilder.Configurations.Add(new SO_MIDDLE_SALEORDER_BMap());
            modelBuilder.Configurations.Add(new UAPBD_MID_DISCARDOUT_BMap());
            modelBuilder.Configurations.Add(new UAPBD_MID_GENERALOUT_BMap());
            modelBuilder.Configurations.Add(new UAPBD_MID_INVCOUNT_BMap());
            modelBuilder.Configurations.Add(new UAPBD_MID_MATERIALMap());
            modelBuilder.Configurations.Add(new UAPBD_MID_RECBILLMap());
            modelBuilder.Configurations.Add(new UAPBD_MID_TRANSFORM_BMap());
            modelBuilder.Configurations.Add(new UAPBD_MID_WHSTRAN_BMap());
            modelBuilder.Configurations.Add(new DBASE_ITEM_MSG_ORGMap());
        }
    }
}
