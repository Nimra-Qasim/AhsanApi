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
    
    public partial class FinalLetter
    {
        public FinalLetter()
        {
            this.FinalLetterDocuments = new HashSet<FinalLetterDocument>();
        }
    
        public string FinalLetterId { get; set; }
        public string UserId { get; set; }
        public Nullable<int> DaysCountAYM { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public Nullable<bool> IsAccessTimeLine { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    
        public virtual ICollection<FinalLetterDocument> FinalLetterDocuments { get; set; }
    }
}
