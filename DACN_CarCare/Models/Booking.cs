using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DACN_CarCare.Models
{
    public partial class Booking : DbContext
    {
        public Booking()
            : base("name=Booking1")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Loai> Loais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
