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
    
    public partial class Stavka_rezanja
    {
        public int ID_Stavka_Rezanja { get; set; }
        public decimal Duzina_rezanja { get; set; }
        public Nullable<decimal> Debljina_pile { get; set; }
        public Nullable<int> Kolicina { get; set; }
        public int Materijal_ID { get; set; }
        public int Skladiste_ID { get; set; }
        public Nullable<int> Ostatak_ID { get; set; }
        public Nullable<int> Plan_ID { get; set; }
    
        public virtual Materijal_na_Skladište Materijal_na_Skladište { get; set; }
        public virtual Ostatak Ostatak { get; set; }
        public virtual Plan_rezanja Plan_rezanja { get; set; }
    }
}