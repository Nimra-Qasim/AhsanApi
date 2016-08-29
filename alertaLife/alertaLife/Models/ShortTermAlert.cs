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
    
    public partial class ShortTermAlert
    {
        public string ShortTermAlertId { get; set; }
        public string Name { get; set; }
        public Nullable<int> AlertTypeId { get; set; }
        public string UserId { get; set; }
        public Nullable<int> SendInterval { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<bool> ContactAlertSent { get; set; }
        public string ContactSubject { get; set; }
        public string ContactMessage { get; set; }
        public Nullable<bool> NormalAlertDone { get; set; }
        public Nullable<bool> ContactAlertDone { get; set; }
        public Nullable<bool> DeathAlertDone { get; set; }
        public Nullable<System.DateTime> UpComingAlert { get; set; }
    }
}