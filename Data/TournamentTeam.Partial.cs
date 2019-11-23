using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public partial class TournamentTeam
    {
        public string TeamName
        {
            get
            {
                if (this.Team == null)
                    return "-";

                return this.Team.Team_Name;
            }
        }
    }
}
