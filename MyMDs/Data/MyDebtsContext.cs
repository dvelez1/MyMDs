using Microsoft.EntityFrameworkCore;
using MyMDs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMDs.Data
{
 


        public class MyDebtsContext : DbContext
        {
            public MyDebtsContext(DbContextOptions<MyDebtsContext> options) : base(options)
            {
            }

            public DbSet<DebtsMaster> debtsMasters { get; set; }
            public DbSet<MyDebts> myDebts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DebtsMaster>().ToTable("DebtsMaster");
            modelBuilder.Entity<MyDebts>().ToTable("MyDebts");
           
        }
    }
    
}
