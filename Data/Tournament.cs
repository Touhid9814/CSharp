//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tournament
    {
        public Tournament()
        {
            this.Fixtures = new HashSet<Fixture>();
        }
    
        public int ID { get; set; }
        public string Tournament_Name { get; set; }
        public string Venue { get; set; }
    
        public virtual ICollection<Fixture> Fixtures { get; set; }
    }
}
