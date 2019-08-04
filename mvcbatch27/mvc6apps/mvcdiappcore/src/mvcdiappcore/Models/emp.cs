using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcdiappcore.Models
{
    public class emp:IEmp
    {
        private int eno;
        private string name;
        public void setemp(int empno,string ename)
        {
            eno = empno;
            name = ename;
          
        }
        public string displayemp()
        {
            string s = "empno:" + eno + "ename:" + name;
            return s;
        }
        public void setempno(int eno1)
        {
            eno = eno1;
        }
    }
}
