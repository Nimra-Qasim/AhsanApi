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
    
    public partial class FinalLetterDocument
    {
        public string FinalLetterDocId { get; set; }
        public string FinalLetterId { get; set; }
        public string VaultDocId { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
    
        public virtual FinalLetter FinalLetter { get; set; }
    }
}
