//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestExample.DB
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    
    public partial class Drivers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drivers()
        {
            this.Turns = new HashSet<Turns>();
        }
    
        public int id { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
        public System.DateTime birth_date { get; set; }
        public bool sex { get; set; }
        public string phone_number { get; set; }
        public string pass_number { get; set; }
        public int rating_sum { get; set; }
        public int rating_count { get; set; }
        public string email { get; set; }
        public string pass_hash { get; set; }
        public bool confirmed { get; set; }
        public int security_code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turns> Turns { get; set; }
    }
}