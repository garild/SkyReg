//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Role = new HashSet<Role>();
        }
    
        public int Id { get; set; }
        public Nullable<int> UsersNr { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string CertificateNr { get; set; }
        public Nullable<System.DateTime> CertificateDate { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role> Role { get; set; }
        public virtual FlightElement FlightElement { get; set; }
        public virtual TandemOrder TandemOrderPilot { get; set; }
        public virtual TandemOrder TandemOrderPassenger { get; set; }
    }
}
