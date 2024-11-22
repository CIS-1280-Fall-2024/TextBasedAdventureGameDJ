﻿// TravelOption
// Programer: Devin Jaramillo
// Date: 11/22/2024
// Represents a travel option.
namespace TextBasedAdventureGame
{
    /// <summary>
    /// Represents a direction player can travel from a given map location.
    /// </summary>
    public class TravelOption
    {
        /// <summary>
        /// Text description of where this travel option goes to.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Reference to location this travel option goes to.
        /// </summary>
        public MapLocation Location { get; set; }

        /// <summary>
        /// Two param constructor
        /// </summary>
        /// <param name="description">Text description of where this travel option goes to.</param>
        /// <param name="location">Reference to location this travel option goes to.</param>
        public TravelOption(string description, MapLocation location)
        {
            Description = description;
            Location = location;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
