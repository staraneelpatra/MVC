//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcdbfirstapp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public string prodid { get; set; }
        public string prodname { get; set; }
        public Nullable<int> prodprice { get; set; }
        public string cateid { get; set; }
    
        public virtual category category { get; set; }
    }
}
