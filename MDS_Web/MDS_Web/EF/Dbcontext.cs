namespace MDS_Web.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Dbcontext : DbContext
    {
        public Dbcontext()
            : base("name=Dbcontext")
        {
        }

        public virtual DbSet<CAUHOI> CAUHOI { get; set; }
        public virtual DbSet<HANGSX> HANGSX { get; set; }
        public virtual DbSet<LOAIXE> LOAIXE { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
