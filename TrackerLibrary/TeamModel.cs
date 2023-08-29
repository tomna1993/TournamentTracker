using System;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// A list of persons who are in the same team (could be one or more people)
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
       
        /// <summary>
        /// Name of the given team
        /// </summary>
        public string TeamName { get; set; }

        public TeamModel()
        {
        }
    }
}