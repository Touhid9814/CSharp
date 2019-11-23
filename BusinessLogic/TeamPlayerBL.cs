using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using SMS.Framework;


namespace BusinessLogic
{
  public  class TeamPlayerBL
    {
        private PlayerDBEntities context = new PlayerDBEntities();

        public Result<List<TeamPlayer>> GetA(int? teamID)
        {
            var result = new Result<List<TeamPlayer>>();

            var query = from d in context.TeamPlayers.AsNoTracking()
                        select d;

            if(teamID.HasValue && teamID.Value>=0)
            {
                query = from d in query where d.TeamID == teamID select d;
            }
          

            result.Data = query.ToList();

            return result;
        }

        public Result<TeamPlayer> Delete(int id)
        {
            var result = new Result<TeamPlayer>();

            try
            {
                var tplayer = context.TeamPlayers.AsNoTracking().FirstOrDefault(d => d.TeamID == id);
                if (tplayer == null)
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid ID");
                    return result;
                }

                context.TeamPlayers.Remove(tplayer);
                context.SaveChanges();

                result.Data = tplayer;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }
            return result;
        }


        public Result<TeamPlayer> SaveTeamPlayer(TeamPlayer tplr)
        {
            var result = new Result<TeamPlayer>();

          /*  if (!ValidationHelper.IsStringValid(tplr.))
            {
                result.HasError = true;
                result.Messages.Add("Invalid Name");
                return result;
            }
            */
            try
            {

                var teamplayer = context.TeamPlayers.AsNoTracking().FirstOrDefault(d => d.ID == tplr.ID);
                if (teamplayer == null)
                {
                    teamplayer = new TeamPlayer();
                    context.TeamPlayers.Add(teamplayer);
                }

                
                
                teamplayer.ID = tplr.ID;
                teamplayer.PlayerID = tplr.PlayerID;
                teamplayer.TeamID= tplr.TeamID;


                context.SaveChanges();

                result.Data = teamplayer;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }


            return result;
        }
    }
}
