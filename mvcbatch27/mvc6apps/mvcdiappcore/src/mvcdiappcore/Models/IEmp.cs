using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcdiappcore.Models
{
    public interface IEmp
    {
        void setemp(int empno, string ename);
        string displayemp();
        void setempno(int eno1);

    }
}
