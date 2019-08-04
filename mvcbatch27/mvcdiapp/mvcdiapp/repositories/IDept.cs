using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcdiapp.repositories
{
   public  interface IDept
    {
       string adddept(int deptno, string dname);
    }
}
