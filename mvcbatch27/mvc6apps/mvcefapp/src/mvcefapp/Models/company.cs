using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace mvcefapp.Models
{
    public class emp
    {
        [Key]
        public int empno { set; get; }
        public string ename { set; get; }
        public int sal { set; get; }
    }
    public class companyDbContext:DbContext
    {
        public DbSet<emp> emps { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder

optionsBuilder)
        {
           // base.OnConfiguring(optionsBuilder);
 optionsBuilder.UseSqlServer("data source=peers-pc;user id=sa;password=123;initial catalog=mvcbatch27");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<emp>().ToTable("emp1");
        }
    }

}
