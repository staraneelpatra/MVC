using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace mvccodefirstapp.Models
{
    public class emp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int empno { set; get; }
        public string ename { set; get; }
        public int sal { set; get; }
        public int deptno { set; get; }
        [ForeignKey("deptno")]
        public dept dinfo { set; get; }
    }






}