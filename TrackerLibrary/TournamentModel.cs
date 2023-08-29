using System;

namespace TrackerLibrary
{
    public class TorunamentModel
    {
        /// <summary>
        /// Name of the selected tournament
        /// </summary>
        public string TrournamentName { get; set; }

        /// <summary>
        /// Torunament Fee per team 
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List of teams who entered the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Contains a list of prizes
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        
        /// <summary>
        /// A matchup is a list of a list of matched teams to compete against each other
        /// </summary>
        public List<List<MatchupModel>> Roudns { get; set; } = new List<List<MatchupModel>>();

        public TorunamentModel()
        {
        }
    }
}