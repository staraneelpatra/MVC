using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypedHTMLHelperControl.Models
{
    public class JobModel
    {
        public String  Name { get; set; }
        public String Password { get; set; }
        public string Gender { get; set; }
        public int Country { get; set; }
        public string Skillset { get; set; }
        public bool TermsAccepted { get; set; }
    }
}