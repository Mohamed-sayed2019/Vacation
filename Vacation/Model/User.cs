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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.User1 = new HashSet<User>();
            this.vactions = new HashSet<vaction>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string postion { get; set; }
        public string department { get; set; }
        public Nullable<int> parent { get; set; }
        public Nullable<int> userrole { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User1 { get; set; }
        public virtual User User2 { get; set; }
        public virtual userrole userrole1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vaction> vactions { get; set; }
        public virtual vactioncridit vactioncridit { get; set; }
    }
}