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
    
    public partial class UserActivityConfiguraion
    {
        public string ActivityConfigID { get; set; }
        public string UserId { get; set; }
        public Nullable<int> ActivityRemindCount { get; set; }
        public Nullable<decimal> ActivityRemindIntervalValue { get; set; }
        public Nullable<int> ContactAlertcount { get; set; }
        public Nullable<decimal> ContactAlertIntervalValue { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public int IsUpdated { get; set; }
    }
}