//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt_PI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Skladište
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Skladište()
        {
            this.Materijal_na_Skladište = new HashSet<Materijal_na_Skladište>();
        }
    
        public int ID_Skladiste { get; set; }
        public string Lokacija { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materijal_na_Skladište> Materijal_na_Skladište { get; set; }
    }
}
