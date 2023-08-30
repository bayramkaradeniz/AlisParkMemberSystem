using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.DataAccess.Concrete
{
    public class AlisParkContext:DbContext
    {
        public AlisParkContext():base("name=connection")
        {
            
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new CategoryMap());
        }
    }
}
