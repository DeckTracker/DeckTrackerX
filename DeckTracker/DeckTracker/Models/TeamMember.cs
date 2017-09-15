
using System;

namespace DeckTracker.Models
{
    public class TeamMember 
    {
        public int TeamMemberId {get; set;}
        public int UserId {get; set;}
        public User User {get; set;}
        public int TeamId {get; set;}
        public Team Team {get; set;}
        public DateTime DateJoined { get; set; }
    }
}