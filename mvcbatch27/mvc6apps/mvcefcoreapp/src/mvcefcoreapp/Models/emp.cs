using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Configuration;

namespace mvcefcoreapp.Models
{
    public class emp
    {
        [Key]
        public int empno { set; get; }
        public string ename { set; get; }
    }
    public class companyDbContext:DbContext
    {
        public DbSet<emp> emps { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            ConfigurationBuilder c = new ConfigurationBuilder();
       
            optionsBuilder.UseSqlServer(@"Server=peers-pc;Database=mvccoredb;user id=sa;password=123"); //-->working
            //optionsBuilder.UseSqlServer(.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<emp>().ToTable("emp");
        }
    }
}
