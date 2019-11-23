using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using SMS.Framework;

namespace BusinessLogic
{
    public class TournamentBL
    {
        private PlayerDBEntities context = new PlayerDBEntities();

        public Result<List<Tournament>> GetAllTournaments(string name = "")
        {
            var result = new Result<List<Tournament>>();

            var query = from tr in context.Tournaments.AsNoTracking()
                        select tr;

            if (ValidationHelper.IsStringValid(name))
            {
                query = from t in query
                        where t.Tournament_Name.Contains(name)
                        select t;
            }

            result.Data = query.ToList();

            return result;
        }

        public Result<Tournament> Delete(int id)
        {
            var result = new Result<Tournament>();

            try
            {
                var tournament = context.Tournaments.AsNoTracking().FirstOrDefault(t => t.ID == id);
                if (tournament == null)
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid ID");
                    return result;
                }

                context.Tournaments.Remove(tournament);
                context.SaveChanges();

                result.Data = tournament;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }
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

        public Result<Tournament> SaveTournament(Tournament tr)
        {
            var result = new Result<Tournament>();

            if (!ValidationHelper.IsStringValid(tr.Tournament_Name))
            {
                result.HasError = true;
                result.Messages.Add("Invalid Name");
                return result;
            }

            try
            {

                var tournament = context.Tournaments.AsNoTracking().FirstOrDefault(t => t.ID == tr.ID);
                if (tournament == null)
                {
                    tournament = new Tournament();
                    context.Tournaments.Add(tournament);
                }

                tournament.Tournament_Name = tr.Tournament_Name;
                tournament.Venue = tr.Venue;
                tournament.ID = tr.ID;

                context.SaveChanges();

                result.Data = tournament;
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
