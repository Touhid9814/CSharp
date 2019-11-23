using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using SMS.Framework;

namespace BusinessLogic
{
    public class TeamBL
    {
        private PlayerDBEntities context = new PlayerDBEntities();

        public Result<List<Team>> GetAllTeams(string name = "")
        {
            var result = new Result<List<Team>>();

            var query = from t in context.Teams.AsNoTracking()
                        select t;

            if (ValidationHelper.IsStringValid(name))
            {
                query = from t in query
                        where t.Team_Name.Contains(name)
                        select t;
            }

            result.Data = query.ToList();

            return result;
        }


        public Result<List<Team>> GetUnusedTeams()
        {
            var result = new Result<List<Team>>();

            var usedTeamsIDs = context.TournamentTeams.AsNoTracking().Select(tt => tt.TeamID).ToArray();

            var query = from d in context.Teams
                        where !usedTeamsIDs.Contains(d.TeamID)
                        select d;

            result.Data = query.ToList();

            return result;
        }


        public Result<Team> GetByID(int tid)
        {
            var result = new Result<Team>();

            var query = (from t in context.Teams.AsNoTracking()
                        where t.TeamID==tid
                        select t).FirstOrDefault();

            result.Data = query;

            return result;
        }

        public Result<Team> Delete(int id)
        {
            var result = new Result<Team>();

            try
            {
                var team = context.Teams.AsNoTracking().FirstOrDefault(t => t.TeamID == id);
                if (team == null)
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid ID");
                    return result;
                }

                context.Teams.Remove(team);
                context.SaveChanges();

                result.Data = team;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }
            return result;
        }


        public Result<Team> SaveTeam(Team tm)
        {
            var result = new Result<Team>();

            if (!ValidationHelper.IsStringValid(tm.Team_Name))
            {
                result.HasError = true;
                result.Messages.Add("Invalid Name");
                return result;
            }

            try
            {

                var team = context.Teams.AsNoTracking().FirstOrDefault(t => t.TeamID == tm.TeamID);
                if (team == null)
                {
                    team = new Team();
                    context.Teams.Add(team);
                }

                team.Team_Name = tm.Team_Name;

                team.TeamID = tm.TeamID;

                context.SaveChanges();

                result.Data = team;
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
