using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace mvccodefirstapp.Models
{
    public class dept
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int deptno { set; get; }
        [Required]//notnull constraint
        public string dname { set; get; }
        public string loc { set; get; }
    }








}