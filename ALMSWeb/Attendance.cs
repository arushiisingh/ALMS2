//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ALMSWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attendance
    {
        public int AttendanceID { get; set; }
        public string AttendanceType { get; set; }
        public System.DateTime AttendanceDate { get; set; }
        public System.TimeSpan InTime { get; set; }
        public System.TimeSpan OutTime { get; set; }
        public int StatusOfAttendance { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> ManagerID { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual Status Status { get; set; }
    }
}
