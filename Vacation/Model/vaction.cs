//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vacation.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class vaction
    {
        public int id { get; set; }
        public Nullable<int> userid { get; set; }
        public Nullable<System.DateTime> vac_from { get; set; }
        public Nullable<System.DateTime> vac_to { get; set; }
        public Nullable<System.DateTime> Returning { get; set; }
        public Nullable<double> duratin { get; set; }
        public string notes { get; set; }
        public Nullable<System.DateTime> submissiondate { get; set; }
    
        public virtual User User { get; set; }
    }
}
