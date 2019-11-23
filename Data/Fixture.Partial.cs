using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public partial class Fixture
    {
        public string Team2Name
        {
            get
            {
                if (this.Team1 == null)
                    return "-";

                return this.Team1.Team_Name;
            }
        }

        public string Team1Name
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
