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
    
    public partial class Materijal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materijal()
        {
            this.Materijal_na_Skladište = new HashSet<Materijal_na_Skladište>();
            this.Ostataks = new HashSet<Ostatak>();
            this.Stavka_primke = new HashSet<Stavka_primke>();
        }
    
        public int ID_Materijal { get; set; }
        public string Naziv_materijala { get; set; }
        public Nullable<decimal> Sirina { get; set; }
        public Nullable<decimal> Duzina { get; set; }
        public Nullable<decimal> Debljina { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materijal_na_Skladište> Materijal_na_Skladište { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ostatak> Ostataks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavka_primke> Stavka_primke { get; set; }
    }
}
