//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeagueOfLegends_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prijs
    {
        public int id { get; set; }
        public System.DateTime BeginDatum { get; set; }
        public System.DateTime EindDatum { get; set; }
        public decimal Prijs1 { get; set; }
        public int StoreId { get; set; }
    
        public virtual Store Store { get; set; }
    }
}