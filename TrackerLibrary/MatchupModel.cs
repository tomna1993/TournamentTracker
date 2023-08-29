using System;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// This is a list of the teams matched up against each other 
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        
        /// <summary>
        /// Represents the name of the winner or winner team
        /// </summary>
        public TeamModel Winner { get; set; }
        
        /// <summary>
        /// Represents the game round in which the teams played
        /// </summary>
        public int MatchupRound { get; set; }

        public MatchupModel()
        {
        }
    }
}