//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int employeeId { get; set; }
        public int userId { get; set; }
        public string Name { get; set; }
        public string surName { get; set; }
    
        public virtual User User { get; set; }
    }
}
