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
    
    public partial class StudentCurrentYear
    {
        public StudentCurrentYear()
        {
            this.Invoices = new HashSet<Invoice>();
        }
    
        public int CurrentYearID { get; set; }
        public System.Guid StudentRefID { get; set; }
        public int SchoolRefID { get; set; }
        public int AcademicYearRefID { get; set; }
        public int ClassRefID { get; set; }
        public short Active { get; set; }
    
        public virtual AcademicYear AcademicYear { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual School School { get; set; }
        public virtual Student Student { get; set; }
    }
}