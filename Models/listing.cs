//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kodisha.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class listing
    {
        [Key]
        [Required(ErrorMessage = "Listing ID is required.")]
        public int listing_ID { get; set; }
        public string PropertyName { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string description { get; set; }
        public string city { get; set; }
        public string area { get; set; }
    }
}
