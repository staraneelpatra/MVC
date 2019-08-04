using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace mvctaghelpersapp.Models
{
   
    public class usermodel
    {
        [Display(Name ="name")]
        [Required(ErrorMessage ="enter name")]
        public string username { set; get; }
        public string password { set; get; }
        [Range(25,40,ErrorMessage ="invalid age")]
        public int age { set; get; }
        public string gender { set; get; }
        public string skillset { set; get; }
        public string country { set; get; }
        public bool termsaccepted { set; get; }
    }







}
