//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Overtime.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Overtimes = new HashSet<Overtime>();
        }
    
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string sub_district { get; set; }
        public string district { get; set; }
        public string province { get; set; }
        public Nullable<int> postal_code { get; set; }
        public Nullable<int> salary { get; set; }
        public Nullable<int> phone { get; set; }
        public Nullable<int> position_id { get; set; }
        public Nullable<bool> isDelete { get; set; }
        public Nullable<System.DateTimeOffset> createDate { get; set; }
        public Nullable<System.DateTimeOffset> updateDate { get; set; }
        public Nullable<System.DateTimeOffset> deleteDate { get; set; }
    
        public virtual Position Position { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Overtime> Overtimes { get; set; }
    }
}
