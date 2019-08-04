using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace mvccodefirstapp.Models
{
    public class companyDbContext:DbContext
    {
        public DbSet<dept> depts { set; get; }
        public DbSet<emp> emps { set; get; }
    }









}