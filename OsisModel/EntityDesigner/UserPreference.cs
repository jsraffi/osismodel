//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OsisModel.EntityDesigner
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserPreference
    {
        public string UserID { get; set; }
        public int SchoolRefID { get; set; }
        public int AcademicYearRefID { get; set; }
    
        public virtual School School { get; set; }
        public virtual AcademicYear AcademicYear { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
