using System;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the number of the places f.e. 1 - first place, 2 - second place
        /// </summary>
        public int PlaceNumber { get; set; }
        
        /// <summary>
        /// Represents the place name given by user, f.e. champion (first place), runner up (second place)
        /// </summary>
        public string PlaceName { get; set; }
        
        /// <summary>
        /// Represents the amount of money assigned to this place 
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of money assigned to this place 
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
        }
    }
}