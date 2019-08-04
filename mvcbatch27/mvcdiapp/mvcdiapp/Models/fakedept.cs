using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvcdiapp.repositories;
namespace mvcdiapp.Models
{
    public class fakedept:IDept
    {
        public string adddept(int deptno,string dname)
        {
            string s = string.Format("fake dept deptno:{0} dname:{1}", deptno, dname);
            return (s);
        }


    }



}