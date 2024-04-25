﻿using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.DataAccess.Concrete
{
    public class AlisParkContext : DbContext
    {
        public AlisParkContext() : base("name=connection")
        {

        }
        public DbSet<Member> Members { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<LogEntry> LogEntries { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Company> CompanyUsers { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new WorkerMap());
            modelBuilder.Configurations.Add(new LogEntryMap());
            modelBuilder.Configurations.Add(new CompanyMap());
        }
    }
}
