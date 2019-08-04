using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvcdiapp.repositories;
namespace mvcdiapp.Models
{
    public class fakeemp:IEmp
    {
        public string addemp(int empno,string ename)
        {
            string s = string.Format("fakeemp empno:{0} ename:{1}", empno, ename);
            return (s);
        }
    }

}