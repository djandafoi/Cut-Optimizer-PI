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
    
    public partial class Skladišna_primka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Skladišna_primka()
        {
            this.Stavka_primke = new HashSet<Stavka_primke>();
        }
    
        public int ID_Primka { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public Nullable<int> Korisnik_ID { get; set; }
        public Nullable<byte> Potvrda { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavka_primke> Stavka_primke { get; set; }
    }
}
