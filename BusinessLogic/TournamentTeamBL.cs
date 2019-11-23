using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using SMS.Framework;


namespace BusinessLogic
{
    public class TournamentTeamBL
    {
        private PlayerDBEntities context = new PlayerDBEntities();

        public Result<List<TournamentTeam>> GetA(int? TourID)
        {
            var result = new Result<List<TournamentTeam>>();

            var query = from t in context.TournamentTeams.AsNoTracking()
                        select t;

            if (TourID.HasValue && TourID.Value >= 0)
            {
                query = from t in query where t.TournamentID == TourID select t;
            }

            /*  if (ValidationHelper.IsStringValid(name))
              {
                  query = from d in query
                          where d.TeamID.Contains(name)
                          select d;
              }*/

           result.Data = query.ToList();

            return result;
        }

        public Result<Tournament> GetByID(int tid)
        {
            var result = new Result<Tournament>();

            var query = (from t in context.Tournaments.AsNoTracking()
                         where t.ID == tid
                         select t).FirstOrDefault();

            result.Data = query;

            return result;
        }

        public Result<TournamentTeam> Delete(int id)
        {
            var result = new Result<TournamentTeam>();

            try
            {
                var tourteam= context.TournamentTeams.AsNoTracking().FirstOrDefault(d => d.ID == id);
                if (tourteam == null)
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid ID");
                    return result;
                }

                context.TournamentTeams.Remove(tourteam);
                context.SaveChanges();

                result.Data = tourteam;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }
            return result;
        }


        public Result<TournamentTeam> SaveTournamentTeam(TournamentTeam trtm)
        {
            var result = new Result<TournamentTeam>();

            /*  if (!ValidationHelper.IsStringValid(tplr.))
              {
                  result.HasError = true;
                  result.Messages.Add("Invalid Name");
                  return result;
              }
              */
           try
            {
                var tourteam = context.TournamentTeams.FirstOrDefault(d => d.ID == trtm.ID);
                if (tourteam == null)
                {
                    tourteam = new TournamentTeam();
                    context.TournamentTeams.Add(tourteam);
                }

                //tourteam.ID = trtm.ID;
                tourteam.TeamID = trtm.TeamID;
                tourteam.TournamentID = trtm.TournamentID;

                result.Data = tourteam;
                context.SaveChanges();

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
