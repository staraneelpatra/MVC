using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace mvcdataannotationsapp.Models
{
    public class usermodel
    {//1st property
        [Display(Name = "username")]
        [Required(ErrorMessage = "enter name")]
        [RegularExpression("[A-Za-z.\\s]{1,20}", ErrorMessage = "enter prop name")]
        public string name { set; get; }
        //2nd prop
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "enter password")]
        public string password { set; get; }
        //3rd prop
        [Compare("password", ErrorMessage = "password mismatch")]
        [Required(ErrorMessage = "enter confirm password")]
        [DataType(DataType.Password)]
        public string confirmpassword { set; get; }
        //4th prop
        [Required(ErrorMessage = "enter addr")]
        [DataType(DataType.MultilineText)]
        public string address { set; get; }
        //5th prop
        [Required(ErrorMessage = "enter age")]
        [Range(25, 40, ErrorMessage = "enter proper age")]
        public int age { set; get; }
        //6th prop
        [RegularExpression("\\d{10}", ErrorMessage = "invalid mobile")]
        public long mobile { set; get; }
        //7th prop
        [DataType(DataType.EmailAddress)]
      
        public string emailid { set; get; }
        //8th prop
        [System.Web.Mvc.Remote("m1", "demo", ErrorMessage = "enter even")]
        public int numb { set; get; }
   }
















}