using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public partial class DBcontext : DbContext
    {
        public DBcontext()
            : base("name=DBcontext")
        {
        }

        public virtual DbSet<tblU> tblU { get; set; }
        public virtual DbSet<tblUsers> tblUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblU>()
                .Property(e => e.UserID)
                .IsFixedLength();

            modelBuilder.Entity<tblU>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<tblU>()
                .Property(e => e.RoleID)
                .IsFixedLength();
        }
    }
}
