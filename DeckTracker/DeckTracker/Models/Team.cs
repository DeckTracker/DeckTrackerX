
using System;
using System.Collections.Generic;
namespace DeckTracker.Models
{
    public class Team
    {
        public int TeamId {get; set;}
        public string TeamName {get; set;}
        public DateTime DateCreated { get; set; }
        public ICollection<TeamMember> TeamMembers {get; set;}
    }
}