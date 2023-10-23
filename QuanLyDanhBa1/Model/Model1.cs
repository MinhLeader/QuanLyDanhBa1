using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyDanhBa1.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model17")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
