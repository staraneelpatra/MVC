using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcdiapp6.Models
{
    public class fakeemployee:IEmployee
    {
        public string addemp(int empno,string ename)
        {
            string s = string.Format("fakeemployee empno:{0} ename:{1}", empno, ename);
            return s;
        }
    }
}
