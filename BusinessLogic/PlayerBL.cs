using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using SMS.Framework;

namespace BusinessLogic
{
    public class PlayerBL
    {
        private PlayerDBEntities context = new PlayerDBEntities();

        public Result<List<Player>> GetAllPlayers(string name = "")
        {
            var result = new Result<List<Player>>();

            var query = from d in context.Players.AsNoTracking()
                        select d;

            if (ValidationHelper.IsStringValid(name))
            {
                query = from d in query
                        where d.Name.Contains(name)
                        select d;
            }

            result.Data = query.ToList();

            return result;
        }

        public Result<List<Player>> GetUnusedPlayers()
        {
            var result = new Result<List<Player>>();

            var usedPlayerIDs = context.TeamPlayers.AsNoTracking().Select(tp => tp.PlayerID).ToArray();

            var query = from d in context.Players.AsNoTracking()
                        where !usedPlayerIDs.Contains(d.PId)
                        select d;

            result.Data = query.ToList();

            return result;
        }

        public Result<Player> Delete(int id)
        {
            var result = new Result<Player>();

            try
            {
                var player = context.Players.AsNoTracking().FirstOrDefault(d => d.PId == id);
                if (player == null)
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid ID");
                    return result;
                }

                context.Players.Remove(player);
                context.SaveChanges();

                result.Data = player;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }
            return result;
        }


        public Result<Player> SavePlayer(Player plr)
        {
            var result = new Result<Player>();

            if (!ValidationHelper.IsStringValid(plr.Name))
            {
                result.HasError = true;
                result.Messages.Add("Invalid Name");
                return result;
            }

            try
            {

                var player = context.Players.AsNoTracking().FirstOrDefault(d => d.PId == plr.PId);
                if (player == null)
                {
                    player = new Player() ;
                    context.Players.Add(player);
                }

                player.Name = plr.Name;
                player.DOB = plr.DOB;
                player.BattingStyle = plr.BattingStyle;
                player.BowlingStyle = plr.BowlingStyle;
                player.PId = plr.PId;
                player.Role = plr.Role;
               
                context.SaveChanges();
                
                result.Data = player;
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
