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
    
    public partial class Team
    {
        public Team()
        {
            this.Fixtures = new HashSet<Fixture>();
            this.Fixtures1 = new HashSet<Fixture>();
            this.TeamPlayers = new HashSet<TeamPlayer>();
            this.TournamentTeams = new HashSet<TournamentTeam>();
        }
    
        public int TeamID { get; set; }
        public string Team_Name { get; set; }
    
        public virtual ICollection<Fixture> Fixtures { get; set; }
        public virtual ICollection<Fixture> Fixtures1 { get; set; }
        public virtual ICollection<TeamPlayer> TeamPlayers { get; set; }
        public virtual ICollection<TournamentTeam> TournamentTeams { get; set; }
    }
}
