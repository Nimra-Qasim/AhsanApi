//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace alertaLife.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProfileCompletionStatu
    {
        public string ProfilePercentageId { get; set; }
        public string UserId { get; set; }
        public string ProfilePercentageMasterId { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual ProfilePercentageMaster ProfilePercentageMaster { get; set; }
    }
}
