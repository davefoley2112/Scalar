//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Interval
    {
        public int Id { get; set; }
        public int ScaleId { get; set; }
        public int ChordId { get; set; }
    
        public virtual Scale Scale { get; set; }
        public virtual Chord Chord { get; set; }
    }
}
