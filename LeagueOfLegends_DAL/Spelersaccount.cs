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
    
    public partial class Spelersaccount
    {
        public int id { get; set; }
        public string GebruikersNaam { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public string Regio { get; set; }
        public System.DateTime Geboortedatum { get; set; }
        public int SpelerId { get; set; }
    
        public virtual Speler Speler { get; set; }
    }
}