//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddLinq1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mitarbeiter
    {
        public int MitarbeiterID { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Position { get; set; }
        public int ProjektID { get; set; }
        public int AbteilungID { get; set; }
    
        public virtual Abteilung Abteilung { get; set; }
        public virtual Projekte Projekte { get; set; }
    }
}
