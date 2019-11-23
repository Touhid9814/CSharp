using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public partial class TeamPlayer
    {
        public string PlayerName
        {
            get
            {
                if (this.Player == null)
                    return "-";

                return this.Player.Name;
            }
        }
    }
}
