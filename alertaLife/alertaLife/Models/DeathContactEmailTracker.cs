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
    
    public partial class DeathContactEmailTracker
    {
        public string DeathtcontactEmailTrackerID { get; set; }
        public string CheckInScheduleID { get; set; }
        public string UserId { get; set; }
        public string ContactId { get; set; }
        public Nullable<bool> isEmailed { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<bool> Isdeleted { get; set; }
    }
}
