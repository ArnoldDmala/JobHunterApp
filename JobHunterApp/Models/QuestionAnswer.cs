//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobHunterApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuestionAnswer
    {
        public int AnswersID { get; set; }
        public int QuestionID { get; set; }
        public int UserID { get; set; }
        public string Answer { get; set; }
    
        public virtual Question Question { get; set; }
        public virtual User User { get; set; }
    }
}
