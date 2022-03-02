using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace familyGroup.Models
{
    public partial class FamilyModel : DbContext
    {
        public FamilyModel()
            : base("name=FamilyModel")
        {
        }

        public virtual DbSet<familyGroup> familyGroup { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
